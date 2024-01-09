namespace CollectionViewInputTransparentTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BindingContext = new MainPageModel(this);
	}

    internal CollectionView GetNonStyledCollectionViewWithIsEnabled()
    {
        return NonStyledCollectionViewWithIsEnabled;
    }

    internal CollectionView GetNonStyledCollectionViewWithInputTransparent()
    {
        return NonStyledCollectionViewWithInputTransparent;
    }
}


