﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using NUnit.Runner.Annotations;

namespace NUnit.Runner.ViewModel {
    class BaseViewModel : INotifyPropertyChanged {
        public INavigation Navigation { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}