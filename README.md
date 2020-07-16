# HandyClasses

This library is a small collection of handy, common classes for use with .NET projects. 

## Base

This library contains the following handy classes:

### BaseModel

Implements a default INotifyPropertyChanged base class.

### BaseViewModel

Inherits from BaseModel, and adds:

- An IsBusy bindable property
- An overridable OnFirstLoad async task

### ActionCommand (and ActionCommand<T>)

The ActionCommand is a basic implementation of ICommand, useful for Xamarin and WPF. With ActionCommand<T> you can specify a command parameter of type T, and a function (CanExecuteCheck) that will set CanExecute based on the parameter. 

### CommonExtensions

Adds common extensions for things like:

- Checking if a string is null
- Casting strings to basic types
- Formatting integers as strings

### ObservableRangeCollection and ObservableSortableCollection

Added to the namespace System.Collections.ObjectModel, these classes provide ObservableCollections that support range operations (AddRange, etc) and sorting operations respectively. 

## WPF

### WpfObservableRangeCollection

Adds a WPF-specific version of the ObservableRangeCollection

## WPF.Dialogs

### OpenFileDialog, SaveFileDialog, FolderBrowserDialog

Add modern dialogs to WPF (otherwise known as Vista-style). Source code is borrowed from Ooki.Dialogs and updated as necessary for .NET Core. 