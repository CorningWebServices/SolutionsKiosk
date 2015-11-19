using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Linq;

namespace MediandoBL
{
	public enum Languages{
		English = 1,
		German = 2
	}

	public interface ILibrary
	{
		Task<IEnumerable<FileInfo>> LibraryInfoAsync (string Category);
		 IEnumerable<Category> LibraryCategoryAsync ();
		IEnumerable<CorningLinks> AboutCorningAsync (Languages lang);
	}

	public class Library //: ILibrary
	{
		public static IEnumerable<Category> LibraryCategoryAsync ()
		{
			var data =  new Category[] {
				new Category ("All", "All"),
				new Category ("articles_and_case_studies", "Articles and Case Studies"),
				new Category ("catalogues_line_cards", "Catalogs/Line Cards"),
				new Category ("generic_specifications", "Generic Specifications"),
				new Category ("installations_design _informationen", "Installation/Design Information"),
				//new Category ("newsletter", "Newsletter"),
				new Category ("product_specifications", "Product Specifications"),
				new Category ("videos", "Videos"),
			};

			return data.AsEnumerable ();
		}

		public IEnumerable<CorningLinks> AboutCorningAsync (Languages lang)
		{
			IEnumerable<CorningLinks> data;
			if (lang == Languages.English) {
				 data = new CorningLinks[] {
					new CorningLinks ("Contact Us", "https://www.corning.com/emea/en/contact-us.html"),
					new CorningLinks ("Corporate", "https://www.corning.com/worldwide/en.html"),
					new CorningLinks ("Data Protection", "http://www.corning.com/emea/en/privacy-policy.html"),
					new CorningLinks ("Copyright", "https://www.corning.com/emea/en/legal-notices.html"),
					new CorningLinks ("Imprint", "http://www.corning.com/emea/en/about-us/news-events/resources/corning-incorporated-logo-usage.html"),
					new CorningLinks ("Newsletter Subscription", "http://www.corning.com/emea/en/about-us/news-events/news-releases.html"),
				}.AsEnumerable();
			} else {
				 data = new CorningLinks[] {
					new CorningLinks ("Kontaktieren Sie Uns", "https://www.corning.com/emea/de/contact-us.html"),
					new CorningLinks ("Firmen-", "https://www.corning.com/worldwide/en.html"),
					new CorningLinks ("Datenschutz", "http://www.corning.com/emea/de/privacy-policy.html"),
					new CorningLinks ("Rechtlicher Hinweis", "https://www.corning.com/emea/de/legal-notices.html"),
					new CorningLinks ("Impressum", "http://www.corning.com/emea/de/about-us/news-events/resources/corning-incorporated-logo-usage.html"),
					new CorningLinks ("Newsletter Abonnieren", "http://www.corning.com/emea/de/about-us/news-events/news-releases.html"),

				}.AsEnumerable();
			}
			return data;
		}


		public static async Task<IEnumerable<FileInfo>> LibraryInfoAsync (string Category)
		{
			string result = null; 
			IEnumerable<FileInfo> data;
			var client = new HttpClient ();
			try 
			{
				result = await client.GetStringAsync (WebApiUrls.Library);
				 data = JsonConvert.DeserializeObject<IEnumerable<FileInfo>> (result).ToList ();
				//return data.Where (i => i.Category == Category).AsEnumerable ();
			} 
			catch 
			{
				result = await client.GetStringAsync (WebApiUrls.Library);
				 data = JsonConvert.DeserializeObject<IEnumerable<FileInfo>> (result).ToList ();
				//return data.Where (i => i.Category == Category).AsEnumerable ();
			}

			if (Category != "All") {
				data = data.Where (i => i.Category == Category).AsEnumerable ();
			} else {
				data = data.Where (i => i.Category != "newsletter").AsEnumerable ();
			}
			return data;
		}
	}

	public class Category
	{

		public Category(string id, string name){
			this.ID = id;
			this.Name = name;
		}

		public string ID { get; set;}
		public string Name{ get; set;}

	}

	public class CorningLinks
	{

		public CorningLinks(string name, string url){

			this.Name = name;
			this.URL = url;
		}

		public string Name{ get; set;}
		public string URL { get; set;}

	}

	public class FileInfo
	{
		private string _uniqueID;

		public string UniqueID {
			get { 
				return _uniqueID;
			}
			set { 
				_uniqueID = value;
			}
		}

		private string _mediaURL;

		public string MediaURL {
			get { 
				return _mediaURL;
			}
			set { 
				_mediaURL = value;
			}
		}

		private string _imageURL;

		public string ImageURL {
			get { 
				return _imageURL;
			}
			set { 
				_imageURL = value;
			}
		}

		private string _directoryname;

		public string DirectoryName {
			get { 
				return _directoryname;
			}
			set { 
				_directoryname = value;
			}
		}

		private string _filename;

		public string FileName {
			get { 
				return _filename;
			}
			set { 
				_filename = value;
			}
		}

		private string _fileLanguage;

		public string FileLanguage {
			get { 
				return _fileLanguage;
			}
			set { 
				_fileLanguage = value;
			}
		}

		private string _name;

		public string Name {
			get { 
				return _name;
			}
			set { 
				_name = value;
			}
		}

		private string _description;

		public string Description {
			get { 
				return _description;
			}
			set { 
				_description = value;
			}
		}

		private string _category;

		public string Category {
			get { 
				return _category;
			}
			set { 
				_category = value;
			}
		}

	}
}

