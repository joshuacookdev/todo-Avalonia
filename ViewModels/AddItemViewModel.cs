using System.Reactive;
using ReactiveUI;
using Todo.Models;
using System;

namespace Todo.ViewModels
{
    class AddItemViewModel : ViewModelBase
    {
        public AddItemViewModel()
        {
            IObservable<bool> okEnabled = this.WhenAnyValue(
                x => x.Description,
                x => !string.IsNullOrWhiteSpace(x));

            Ok = ReactiveCommand.Create(() => 
                new TodoItem {Description = Description}, okEnabled);
            
            Cancel = ReactiveCommand.Create(() => { });
        }
        string description;
        public string Description
        {
            get => description;
            set => this.RaiseAndSetIfChanged(ref description, value);
        }

        public ReactiveCommand<Unit, TodoItem> Ok { get; }
        public ReactiveCommand<Unit, Unit> Cancel { get; }
    }
}