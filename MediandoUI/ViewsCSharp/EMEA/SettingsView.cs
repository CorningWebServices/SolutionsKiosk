using System;

using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;

namespace MediandoUI
{
	public class SettingsView : BaseContentPage
	{
		readonly Button btnTmpFiles;
		readonly Button btnMediaFiles;
		//readonly Picker languagePicker;
		List<Language> languages;

		public SettingsView ()
		{
			
			NavigationPage.SetHasNavigationBar (this, false);



			btnTmpFiles = new Button {
				HorizontalOptions = LayoutOptions.Start,
				TextColor = Color.Black,
				Command = new Command (() => {
					var deleteService = DependencyService.Get<IDeleteService> ();
					if (deleteService == null)
						return;

					deleteService.DeleteTempFiles ((bool completed) => {
						if (completed == true) {
							btnTmpFiles.Text = Translation.Localize("DeleteTempFiles");
							DisplayAlert ("", Translation.Localize("TempFilesDeletedMessage"), Translation.Localize("Ok"));
						} else {
							DisplayAlert ("", "Error Occured.", Translation.Localize("Ok"));
						}
					});

				}),
			};

			btnMediaFiles = new Button {
				HorizontalOptions = LayoutOptions.Start,
				TextColor = Color.Black,
				Command = new Command (async () => {
					var confirm = await DisplayAlert ("", Translation.Localize("DeleteMediaMessage"), Translation.Localize("Yes"), Translation.Localize("No"));
					if (confirm) {
						var deleteService = DependencyService.Get<IDeleteService> ();
						if (deleteService == null)
							return;

						deleteService.DeleteAllMedia ((bool completed) => {
							if (completed == true) {
								
								db.DeleteAllDownloads ();
								btnMediaFiles.Text = Translation.Localize("DeleteMediaFiles");
								DisplayAlert ("", Translation.Localize("MediaFilesDeletedMessage"), Translation.Localize("Ok"));
							} else {
								DisplayAlert ("", "Error Occured.", Translation.Localize("Ok"));
							}
						});
					}
				}),
			};
				
				
			var switchCell = new SwitchCell ();
			switchCell.Text = Translation.Localize("DownloadviaWifi"); 
			switchCell.On = GlobalVariables.WifiDownloadOnly;
			switchCell.OnChanged += (sender, args) =>
			{
				var selectedValue = (sender as SwitchCell).On;
				db.UpdateSettings ("WifiDownload", selectedValue == true ? "1" : "0");
			};


				
			TableView tableView = new TableView {
				BackgroundColor = Color.Transparent,
				Intent = TableIntent.Settings,
				
				Root = new TableRoot ("") {
					new TableSection (Translation.Localize("SettingsIcon")) {
						new ViewCell {
							View = btnTmpFiles,
						},
						new ViewCell {
							View = btnMediaFiles
						},
						switchCell,
					},
					new TableSection ("Version 1.5 (03-September-2015)") {
//						new ViewCell { View = languagePicker },
//						new ViewCell {
//							View = new Label {
//								HorizontalOptions = LayoutOptions.Start,
//								VerticalOptions = LayoutOptions.Center,
//								Text = "Version 1.1 (15-July-2015)"
//							},
//						}
					},
				},
			};
				
			// Build the page.
			this.Content = new StackLayout {
				Children = {
					ControlUtilities.GetAppHeader (),
					tableView
				}
			};

			Device.OnPlatform (
				iOS: () => {
					this.Content = new StackLayout {
						Children = {
							ControlUtilities.GetAppHeader (),
							tableView
						}
					};
				},
				Android: () => {
					this.Content = new StackLayout {
						Children = {
							//ControlUtilities.GetAppHeader (),
							tableView
						}
					};
				},
				WinPhone: () => {
					this.Content = new StackLayout {
						Children = {
							ControlUtilities.GetAppHeader (),
							tableView
						}
					};
				}
			);

		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			var masterPage = this.Parent.Parent as TabbedPage;
			masterPage.Children [0].Title =  Translation.Localize ("HomeIcon");

			var fileService = DependencyService.Get<IFileService> ();
			if (fileService != null) {
				fileService.GetTempSize ((long size) => {
					string value = "";
					if (size > 0) {
						if (size < 1000)
							value = "(" + size + " bytes)";
						else if (size >= 1000 && size < 1000000)
							value = "(" + size / 1000 + " KB)";
						else if (size >= 1000000 && size < 1000000000)
							value = "(" + size / 1000000 + " MB)";
						else
							value = "(" + size / 1000000000 + " GB)";
					}
				
					btnTmpFiles.Text =  Translation.Localize("DeleteTempFiles") + " " + value;
				});

				fileService.GetMediaSize ((long size) => {
					string value = "";
					if (size > 0) {
						if (size < 1000)
							value = "(" + size + " bytes)";
						else if (size >= 1000 && size < 1000000)
							value = "(" + size / 1000 + " KB)";
						else if (size >= 1000000 && size < 1000000000)
							value = "(" + size / 1000000 + " MB)";
						else
							value = "(" + size / 1000000000 + " GB)";
					}
					btnMediaFiles.Text = Translation.Localize("DeleteMediaFiles") + " " + value;

				});
			}
//			var settings = db.GetDefaultSettings ().ToList ();
//			var langValue = settings.FirstOrDefault (i => i.Key == "Language").Value;
//
//			if (languagePicker.Items.Count == 0) {
//				languages = db.GetLanguages ().OrderBy(i=>i.LanguageName).ToList();
//
//				foreach (var lang in languages) {
//					languagePicker.Items.Add (lang.LanguageName);
//				}
//			}
//
//			if (langValue == "British_English") {
//				languagePicker.SelectedIndex = 0;
//			} else {
//				languagePicker.SelectedIndex = 1;
//			}

		}

	 
	}
}


