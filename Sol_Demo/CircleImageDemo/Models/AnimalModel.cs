using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircleImageDemo.Models
{
    public class AnimalModel : ObservableObject
    {
        private String source;

        public String Source
        {
            get => source;
            set => base.SetProperty(ref source, value);
        }
    }
}