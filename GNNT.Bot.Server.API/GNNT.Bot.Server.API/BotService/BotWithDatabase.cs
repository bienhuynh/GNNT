using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GNNT.Bot.Server.API.Firebase;
namespace GNNT.Bot.Server.API.BotService
{
    public class BotWithDatabase
    {
        private FirebaseDbService db;
        private string URLRequest;
        public BotWithDatabase(string requestURL)
        {
            URLRequest = requestURL;
        }

        public void BotSendMessageText(Models.MessageText record)
        {
            db = new FirebaseDbService();
            string json = JsonConvert.SerializeObject(new
            {
                name = record.name,
                photoUrl = record.photoUrl,
                text = record.message
            });
            db.POSTWriteRecord(json, URLRequest);
        }
        public void BotSendListMessageText(List<Models.MessageText> listMessage)
        {
            foreach(Models.MessageText item in listMessage)
            {
                BotSendMessageText(item);
            }
        }

        public void ChangeURLRequest(string newUrl)
        {
            URLRequest = newUrl;
        }

        public string ShowURLRequest()
        {
            return URLRequest;
        }
    }
}