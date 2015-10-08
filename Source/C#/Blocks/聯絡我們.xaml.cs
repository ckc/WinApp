﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Limilabs.Client.SMTP;
using Limilabs.Mail;
using Limilabs.Mail.Headers;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Brainvita;
using System.Net;



// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Blocks
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class ScorePage : Blocks.Common.LayoutAwarePage
    {


        public ScorePage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

    
        
        public async void btnSend_Click(object sender, RoutedEventArgs e)
        {
            MailBuilder myMail = new MailBuilder();
            myMail.Html = problem.Text;
            myMail.Subject = subject.Text;

           
            myMail.To.Add(new MailBox(txtemail.Text));
            myMail.From.Add(new MailBox(subject.Text));
         

            IMail email = myMail.Create();

            try
            {
                using (Smtp smtp = new Smtp())
                {
                    await smtp.Connect("smtp.mail.yahoo.com.hk",465);
                    await smtp.UseBestLoginAsync("knowledgeofprince11@yahoo.com.hk", "tyive123");
                    await smtp.SendMessageAsync(email);
                    await smtp.CloseAsync();
                    MessageDialog msg = new MessageDialog("Mail has been sucessfully sent");
                    await msg.ShowAsync();
                }
            }
            catch (Exception ex)
            {
                MessageDialog msg = new MessageDialog("Mail has been sucessfully sent");
                msg.ShowAsync();
            }
        }


   


    }
}
