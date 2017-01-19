﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Shared_Code_Portable;
using Shared_Code_Portable.ClientSide;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoviedUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            ServerInfo.Init(() =>
            {
                Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
                {
                    LoginButton.IsEnabled = true;                    
                });
            });
            this.InitializeComponent();
        }

        private bool requestInProgress = false;

        private void LoginButton_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            if (requestInProgress) return;
            requestInProgress = true;

            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            int userid = -1;

            ServerHandler.instance.SendMessage(new Message
            {
                destinationID = ServerHandler.instance.serverNodeID,
                senderID = ServerHandler.instance.clientID,
                traceNumber = TraceID.GenerateTraceID(),
                type = Message.Type.ClientServer.Login.saltRequest,
                isResponse = false,
                succes = true,
                message = new {username}
            }, m1 =>
            {
            //Debugger.Break();
            if (m1.succes == false)
            {
                Dispatcher.RunAsync(CoreDispatcherPriority.High, () => UsernameTextBox.Background = new SolidColorBrush(Color.FromArgb(75, 175, 0, 0)));
                requestInProgress = false;
            }
            else
            {
                Dispatcher.RunAsync(CoreDispatcherPriority.High, () => UsernameTextBox.Background = new SolidColorBrush(Colors.Transparent));
                byte[] saltBytes = Convert.FromBase64String((string)m1.message.salt);
                string hash = Convert.ToBase64String(ServerInfo.HashPasword(password, saltBytes));
                userid = m1.message.userid;
                ServerHandler.instance.SendMessage(new Message
                {
                    destinationID = m1.senderID,
                    senderID = m1.destinationID,
                    traceNumber = m1.traceNumber,
                    type = Message.Type.ClientServer.Login.checkHash,
                    isResponse = false,
                    succes = true,
                    message = new
                    {
                        userid = userid,
                        hash = hash
                    }
                }, m2 =>
                {
                    //Debugger.Break();
                    if ((ServerInfo.Response) m2.message.response == ServerInfo.Response.SUCCES)
                    {                     
                        Dispatcher.RunAsync(CoreDispatcherPriority.High, () => Frame.Navigate(typeof(MainPage)));
                    }
                    else
                    {
                        Dispatcher.RunAsync(CoreDispatcherPriority.High, () => PasswordTextBox.Background = new SolidColorBrush(Color.FromArgb(75, 175, 0, 0)));
                        requestInProgress = false;
                    }
                });
            }
            });
        }

        private void NewUser_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            //TODO CHECK WITH SERVER @FLOBO!!
            if (UsernameTextBox.Text == "" || UsernameTextBox.Text == "username")
            {
                UsernameTextBox.Background = new SolidColorBrush(new Color());
            }
            if (UsernameTextBox.Text == "" || UsernameTextBox.Text == "password")
            {
                PasswordTextBox.Background = new SolidColorBrush(new Color());
            }
            else
            {
                //TODO ADD NEW USER ON SERVER @FLOBO
                Frame.Navigate(typeof(MainPage));
            }
        }
    }
}