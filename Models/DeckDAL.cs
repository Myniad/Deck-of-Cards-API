using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Serialization;

namespace Deck_of_Cards_API.Models
{
    public class DeckDAL
    {
        public static DeckModel GetDeck()
        {


            //setup
            string url = "https://deckofcardsapi.com/api/deck/new/draw/?count=5";




            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();   //casting

            
            //convert to json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

           
            //convert to c#
            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(JSON);

            return result;


        }


    }
}
