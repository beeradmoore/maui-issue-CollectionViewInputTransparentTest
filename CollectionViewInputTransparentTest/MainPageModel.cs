using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CollectionViewInputTransparentTest;

public partial class MainPageModel : ObservableObject
{
    public List<string> Items { get; } = new List<string>()
    {
        "Item 1",
        "Item 2",
        "Item 3",
        "Item 4",
        "Item 5",
    };

    [ObservableProperty]
    bool isCollectionViewEnabled = true;

    MainPage mainPage;

    public MainPageModel(MainPage mainPage)
    {
        this.mainPage = mainPage;
    }



    [RelayCommand]
    void IsEnabledFalseCollectionView()
    {
        IsCollectionViewEnabled = false;

        mainPage.GetNonStyledCollectionViewWithIsEnabled().IsEnabled = false;

        mainPage.GetNonStyledCollectionViewWithInputTransparent().Opacity = 0.5;
        mainPage.GetNonStyledCollectionViewWithInputTransparent().InputTransparent = true;
    }

    [RelayCommand]
    void IsEnabledTrueCollectionView()
    {
        IsCollectionViewEnabled = true;

        mainPage.GetNonStyledCollectionViewWithIsEnabled().IsEnabled = true;

        mainPage.GetNonStyledCollectionViewWithInputTransparent().Opacity = 1;
        mainPage.GetNonStyledCollectionViewWithInputTransparent().InputTransparent = false;
    }
}

