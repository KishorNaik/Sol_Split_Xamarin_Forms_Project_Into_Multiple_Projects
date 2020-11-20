using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardViewDemo.Models
{
    public class UserModel : ObservableObject
    {
        private string fullName;

        public String FullName
        {
            get => fullName;
            set => base.SetProperty(ref fullName, value);
        }
    }
}