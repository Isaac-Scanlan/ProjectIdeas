using Microsoft.Extensions.Logging;
using ProjectIdeas.ViewModels.BaseViewModels;
using ProjectIdeas.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjectIdeas.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly ILogger<MainWindowViewModel> _logger;

    private Page _currentPage;
    private Page _newProjectPage;
    private Page _projectTablePage;
    private Page _settingsPage;
    private Page _aboutPage;

    public Page CuttentPage
    {
        get => _currentPage;
        set
        {
            _currentPage = value;
        }
    }

    public ICommand NavigateToNewProjectPage { get; }
    public ICommand NavigateToProjectTablePage { get; }
    public ICommand NavigateToSettingsPage { get; }
    public ICommand NavigateToAboutPage { get; }


    public MainWindowViewModel(ILogger<MainWindowViewModel> logger, NewProjectPage newProjectPage, ProjectTablePage projectTablePage, SettingsPage settingsPage, AboutPage aboutPage)
    {
        _logger = logger;

        _newProjectPage = newProjectPage;
        _projectTablePage = projectTablePage;
        _settingsPage = settingsPage;
        _aboutPage = aboutPage;
    }
}
