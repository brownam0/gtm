using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogMeIn.GoToCoreLib.Api;
using LogMeIn.GoToMeeting.Api;

namespace gtm
{
     class Program
     {
          static void Main(string[] args)
          {

               string[] userName = new string[5];
               string[] userPassword = new string[5];
               string[] consumerKey = new string[5];
               int i;

               
               userName[0] = "apprenticeships@bcs.uk";
               userPassword[0] = "apprenticeship123";
               consumerKey[0] = "	deUbbIVOpyiHCpA10ogMAI5VWMJ7GDNb";

               userName[1] = "epa1@bcs.uk";
               userPassword[1] = "chocolatemuffin01";
               consumerKey[1] = "	deUbbIVOpyiHCpA10ogMAI5VWMJ7GDNb";

               userName[2] = "epa2@bcs.uk";
               userPassword[2] = "blueberrymuffin02";
               consumerKey[2] = "	deUbbIVOpyiHCpA10ogMAI5VWMJ7GDNb";

               userName[3] = "epa3@bcs.uk";
               userPassword[3] = "Chocolate18";
               consumerKey[3] = "	deUbbIVOpyiHCpA10ogMAI5VWMJ7GDNb";

               userName[4] = "epa4@bcs.uk";
               userPassword[4] = "password123";
               consumerKey[4] = "	deUbbIVOpyiHCpA10ogMAI5VWMJ7GDNb";

               var authApi = new AuthenticationApi();

               for (i= 0; i<5; i++)
                {
                    try
                    {
                         var response = authApi.directLogin(userName[i], userPassword[i], consumerKey[i], "password");
                         var accessToken = response.access_token;

                         var meetingsApi = new MeetingsApi();
                         var meetings = meetingsApi.getUpcomingMeetings(accessToken);

                         foreach (var m in meetings)
                         {
                              Console.WriteLine("{0}|{1}|{2}|{3}", userName[i], m.meetingId, m.startTime, m.subject);
                         }
                    }
                    catch
                    {
                         // Stop error on screen
                    }


                         

                    }


          }
     }
}
