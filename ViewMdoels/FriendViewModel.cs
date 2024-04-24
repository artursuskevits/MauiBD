using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiBD.Models;

namespace MauiBD.ViewMdoels
{
    public class FriendViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        FriendListViewModel lvm;
        public Friend friend { get; private set; }

        public FriendViewModel()
        {
            friend = new Friend();
        }
        public FriendListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                { lvm = value;
                    OnPropertyChanged("ListViewModel");
                        }
            }
        }
        public string Name
        {
            get { return friend.Name; }
            set
            {
                if (friend.Name != value)
                {
                    friend.Name=value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Email
        {
            get { return friend.Email; }
            set
            {
                if (friend.Email != value)
                {
                    friend.Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        public string Phone
        {
            get { return friend.Phone; }
            set
            {
                if (friend.Phone != value)
                {
                    friend.Phone = value;
                    OnPropertyChanged("Phone");
                }
            }
        }
        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim())) ||
                 (!string.IsNullOrEmpty(Phone.Trim())) ||
                 (!string.IsNullOrEmpty(Email.Trim())));
            }
        }
        protected void OnPropertyChanged(string propNmae)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propNmae));
        }


    }
}
