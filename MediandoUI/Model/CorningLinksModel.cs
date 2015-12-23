using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Linq;

namespace MediandoUI
{

	public interface ILibrary
	{
		IEnumerable<CorningLinks> AboutCorningAsync (string lang);
	}

	public class Library //: ILibrary
	{
		public IEnumerable<CorningLinks> AboutCorningAsync (string lang)
		{
			List<CorningLinks> data;
			if (lang == "German") {
				data =new List<CorningLinks> (); 
				data.Add (new CorningLinks ("Kontaktieren Sie uns", "https://www.corning.com/emea/de/contact-us.html"));
				data.Add (new CorningLinks ("Unternehmen", "https://www.corning.com/emea/de/about-us/company-profile.html"));
				data.Add (new CorningLinks ("Datenschutz", "http://www.corning.com/emea/de/privacy-policy.html"));
				data.Add (new CorningLinks ("Rechtlicher Hinweis", "https://www.corning.com/emea/de/legal-notices.html"));
				data.Add (new CorningLinks ("Impressum", "http://www.corning.com/emea/de/about-us/news-events/resources/corning-incorporated-logo-usage.html"));
				data.Add (new CorningLinks ("Newsletter abonnieren", "http://opcomm.corning.com/3-Email-Subscriptions-DE.html"));


			} else {
				data =new List<CorningLinks> (); 
				data.Add (new CorningLinks ("Contact Us", "https://www.corning.com/emea/en/contact-us.html"));
				data.Add (new CorningLinks ("Corporate", "https://www.corning.com/emea/en/about-us/company-profile.html"));
				data.Add (new CorningLinks ("Data Protection", "http://www.corning.com/emea/en/privacy-policy.html"));
				data.Add (new CorningLinks ("Copyright", "https://www.corning.com/emea/en/legal-notices.html"));
				data.Add (new CorningLinks ("Imprint", "http://www.corning.com/emea/en/about-us/news-events/resources/corning-incorporated-logo-usage.html"));
				data.Add (new CorningLinks ("Newsletter Subscription", "http://opcomm.corning.com/3-Email-Subscriptions-EN.html"));

			}
			return data.AsEnumerable ();
		}
	}


	public class CorningLinks
	{

		public CorningLinks (string name, string url)
		{

			this.Name = name;
			this.URL = url;
		}

		public string Name{ get; set; }

		public string URL { get; set; }

	}
		
}

