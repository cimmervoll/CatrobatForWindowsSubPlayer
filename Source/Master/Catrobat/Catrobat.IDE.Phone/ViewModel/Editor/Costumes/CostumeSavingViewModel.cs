﻿using System.Windows;
using System.Windows.Controls;
using Catrobat.IDE.Core.CatrobatObjects;
using Catrobat.IDE.Core.Resources.Localization;
using Catrobat.IDE.Core.Services;
using Catrobat.IDE.Core.UI;
using Catrobat.IDE.Core.UI.PortableUI;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Catrobat.IDE.Phone.ViewModel.Editor.Costumes
{
    public class CostumeSavingViewModel : ViewModelBase
    {
        #region Private Members

        private PortableImage _image;

        #endregion

        #region Properties

        public PortableImage Image
        {
            get { return _image; }
            set
            {
                _image = value;
                RaisePropertyChanged(() => Image);
            }
        }

        #endregion

        #region Commands

        
        #endregion

        #region CommandCanExecute

      
        #endregion

        #region Actions

        

        #endregion

        #region MessageActions

        private void CostumeImageReceivedMessageAction(GenericMessage<PortableImage> message)
        {
            Image = message.Content;
        }

        #endregion

        public CostumeSavingViewModel()
        {
            
            Messenger.Default.Register<GenericMessage<PortableImage>>(this,
                ViewModelMessagingToken.CostumeImageToSaveListener, CostumeImageReceivedMessageAction);
        }
    }
}