using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using Firebase.Database;
using System.Reactive.Linq;
using GNNT.Bot.Server.API.Models;
using Firebase.Database.Query;
using Firebase.Database.Streaming;
using GNNT.Bot.Server.Model;

namespace GNNT.Bot.Server.API.Firebase
{
    public class FirebaseDbService
    {
        public void POSTWriteRecord(string json, string requestURLString)
        {
            var request = WebRequest.CreateHttp(requestURLString);
            request.Method = "POST";
            request.ContentType = "application/json";
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            var response = request.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();
        }
        private List<Answer> Search(List<MPlace> dataPlaces, string message)
        {
            BotService.BotWithDatabase bot = new BotService.BotWithDatabase("https://fifo-88857.firebaseio.com/messages/.json");
            foreach (MPlace item in dataPlaces)
            {
                foreach (Ask i in item.askList)
                {
                    if (i.Text == message)
                    {
                        List<Models.MessageText> listMessage = new List<Models.MessageText>();
                        foreach (Answer anwser in item.answerlist)
                        {
                            listMessage.Add(new Models.MessageText { name = "Bot", text = anwser.Text, photoUrl = "https://fifo-88857.firebaseio.com/messages/.json" });
                        }
                        bot.BotSendListMessageText(listMessage);
                        return item.answerlist;
                    }
                }
            }
            return null;
        }
        //public IObservable<FirebaseEvent<MessageText>> Read(List<MPlace> data)
        //{
        //    FirebaseClient client = new FirebaseClient("https://fifo-88857.firebaseio.com/messages/.json");
        //    ChildQuery child = client.Child("messages");

        //    var observable = child.AsObservable<MessageText>();
            
        //    // subscribe to messages comming in, ignoring the ones that are from me
        //    //IObservable<FirebaseEvent<MessageText>> subscription = observable
        //    //    .Where(f => !string.IsNullOrEmpty(f.Key)) // you get empty Key when there are no data on the server for specified node
        //    //                                              //.Where(f => f.Object?.Author != name)
        //    //                                              .Subscribe(f => Search(data,f.Object.message));
            
        //    return subscription;
        //}
    }
}