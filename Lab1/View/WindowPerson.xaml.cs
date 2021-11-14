using System.Windows;
using Lab1.ViewModel;
using Lab1.Helper;
using Lab1.Model;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;


namespace Lab1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowPerson.xaml
    /// </summary>
    public partial class WindowPerson : Window
    {
        public WindowPerson()
        {
            InitializeComponent();
            PersonViewModel vmPerson = new PersonViewModel();
            VerietyViewModel vmVeriety = new VerietyViewModel();
            StatusViewModel vmStatus = new StatusViewModel();
            List<VerietyPerson> verieties = new List<VerietyPerson>();
            List<StatusPerson> statuses = new List<StatusPerson>();
            foreach (VerietyPerson v in vmVeriety.ListVerietyPerson)
            {
                verieties.Add(v);
            }
            foreach (StatusPerson s in vmStatus.ListStatusPerson)
            {
                statuses.Add(s);
            }
            ObservableCollection<PersonDPO> persons = new ObservableCollection<PersonDPO>();
            FindVeriety finderV;
            FindStatus finderS;
            foreach (var p in vmPerson.ListPerson)
            {
                finderV = new FindVeriety(p.VerietyID);
                finderS = new FindStatus(p.StatusID);
                VerietyPerson Ver = verieties.Find(new Predicate<VerietyPerson>
                    (finderV.RolePredicate));
                StatusPerson Stat = statuses.Find(new Predicate<StatusPerson>
                    (finderS.RolePredicate));
                persons.Add(new PersonDPO
                {
                    Id = p.Id,
                    Veriety = Ver.Veriety,
                    Status = Stat.Status,
                    Inn = p.Inn,
                    Type = p.Type,
                    Shifer = p.Shifer,
                    Data = p.Data
                });
            }
            lvClients.ItemsSource = persons;
        }
    }
}