using NetflixApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace NetflixApp.PageModels
{
    public class OnboardingPageModel : BasePageModel
    {
        public ObservableCollection<OnboardingModel> OnboardingModels { get; set; } = new ObservableCollection<OnboardingModel>();
        public Command NavigateToSignInCommand { get; set; }
        public OnboardingPageModel() 
        {
            NavigateToSignInCommand = new Command(() =>
            {
                CoreMethods.PushPageModel<SigninPageModel>();
            });
        }

        public override void Init (object initData)
        {
            base.Init (initData);

            OnboardingModels.Add(new OnboardingModel()
            {
                Titre = "Regardez n'importe où. Arrêtez n'importe quand.",
                SousTitre = "Films, Séries TV et bien plus en illimité",
                ImageSource = "img1",
                IsFill = true
            });

            OnboardingModels.Add(new OnboardingModel()
            {
                Titre = "Téléchargez et regardez hors ligne.",
                SousTitre = "Ayez toujours quelque chose à regarder même hors ligne",
                ImageSource = "img2",
                IsFill = false
            });

            OnboardingModels.Add(new OnboardingModel()
            {
                Titre = "Rejoignez nous aujourd'hui, partez quand vous voulez.",
                SousTitre = "Pas de contrat contraignant",
                ImageSource = "img3",
                IsFill = false
            });

            OnboardingModels.Add(new OnboardingModel()
            {
                Titre = "Regardez sur votre mobile, tablette, ordinateur, TV et plus.",
                SousTitre = "Regardez partout",
                ImageSource = "img4",
                IsFill = false
            }); 
        }
    }
}
