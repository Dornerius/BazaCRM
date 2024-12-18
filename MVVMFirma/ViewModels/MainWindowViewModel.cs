using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Helper;
using System.Diagnostics;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Data;

namespace MVVMFirma.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Fields
        private ReadOnlyCollection<CommandViewModel> _Commands;
        private ObservableCollection<WorkspaceViewModel> _Workspaces;
        #endregion

        #region Commands
        public ReadOnlyCollection<CommandViewModel> Commands
        {
            get
            {
                if (_Commands == null)
                {
                    List<CommandViewModel> cmds = this.CreateCommands();
                    _Commands = new ReadOnlyCollection<CommandViewModel>(cmds);
                }
                return _Commands;
            }
        }
        private List<CommandViewModel> CreateCommands()
        {
            return new List<CommandViewModel>
            {
                new CommandViewModel(
                    "Klienci",
                    new BaseCommand(() => this.ShowAllView<WszyscyKlienciViewModel>())),

                new CommandViewModel(
                    "Nowy Klient",
                    new BaseCommand(() => this.CreateView(new NowyKlientViewModel()))),

                new CommandViewModel(
                    "Projekty",
                    new BaseCommand(() => this.ShowAllView<WszystkieProjektyViewModel>())),

                new CommandViewModel(
                    "Nowy Projekt",
                    new BaseCommand(() => this.CreateView(new NowyProjektViewModel()))),

                new CommandViewModel(
                    "Produkty i Usługi",
                    new BaseCommand(() => this.ShowAllView<WszyscyProduktyViewModel>())),

                new CommandViewModel(
                    "Nowy Produkt, Usługa",
                    new BaseCommand(() => this.CreateView(new NowyProduktViewModel()))),

                new CommandViewModel(
                    "Transakcje",
                    new BaseCommand(() => this.ShowAllView<WszystkieTransakcjeViewModel>())),

                new CommandViewModel(
                    "Nowa Transakcja",
                    new BaseCommand(() => this.CreateView(new NowaTransakcjaViewModel()))),

                new CommandViewModel(
                    "Wszystkie Faktury",
                    new BaseCommand(() => this.ShowAllView<WszystkieFakturyViewModel>())),

                new CommandViewModel(
                    "Wystaw Fakturę",
                    new BaseCommand(() => this.CreateView(new NowaFakturaViewModel()))),

                new CommandViewModel(
                    "Nowy Użytkownik",
                    new BaseCommand(() => this.CreateView(new NowyUzytkownikViewModel()))),

                new CommandViewModel(
                    "Użytkownicy",
                    new BaseCommand(() => this.ShowAllView<WszyscyUzytkownicyViewModel>())),

                new CommandViewModel(
                    "Dodaj Zespół",
                    new BaseCommand(() => this.CreateView(new NowyZespolViewModel()))),

                new CommandViewModel(
                    "Zwspoły",
                    new BaseCommand(() => this.ShowAllView<WszystkieZespolyViewModel>())),

            };
        }
        #endregion

        #region Workspaces
        public ObservableCollection<WorkspaceViewModel> Workspaces
        {
            get
            {
                if (_Workspaces == null)
                {
                    _Workspaces = new ObservableCollection<WorkspaceViewModel>();
                    _Workspaces.CollectionChanged += this.OnWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        private void OnWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null && e.NewItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += this.OnWorkspaceRequestClose;

            if (e.OldItems != null && e.OldItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.OldItems)
                    workspace.RequestClose -= this.OnWorkspaceRequestClose;
        }
        private void OnWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkspaceViewModel workspace = sender as WorkspaceViewModel;
            //workspace.Dispos();
            this.Workspaces.Remove(workspace);
        }

        #endregion // Workspaces

        #region Private Helpers
        private void CreateView(WorkspaceViewModel nowy)
        {
            
            this.Workspaces.Add(nowy);
            this.SetActiveWorkspace(nowy);
        }
        //private void CreateFaktura()
        //{
        //    NowaFakturaViewModel workspace = new NowaFakturaViewModel();
        //    this.Workspaces.Add(workspace);
        //    this.SetActiveWorkspace(workspace);
        //}
        private void ShowAllView<T>() where T : WorkspaceViewModel, new()
        {
            T workspace = this.Workspaces.FirstOrDefault(vm => vm is T) as T;
            if (workspace == null)
            {
                workspace = new T();
                this.Workspaces.Add(workspace);
            }

            this.SetActiveWorkspace(workspace);
        }
        //private void ShowAllFaktury()
        //{
        //    WszystkieFakturyViewModel workspace =
        //        this.Workspaces.FirstOrDefault(vm => vm is WszystkieFakturyViewModel)
        //        as WszystkieFakturyViewModel;
        //    if (workspace == null)
        //    {
        //        workspace = new WszystkieFakturyViewModel();
        //        this.Workspaces.Add(workspace);
        //    }

        //    this.SetActiveWorkspace(workspace);
        //}
        private void SetActiveWorkspace(WorkspaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));

            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null)
                collectionView.MoveCurrentTo(workspace);
        }
        #endregion
    }
}
