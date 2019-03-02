

namespace Shop5.UIForms.ViewModels
{
    using Shop5.Common.Models;
    using Shop5.Common.Services;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public class ProductViewModel :BaseViewModel
    {
        private readonly ApiService apiService;
        private ObservableCollection<Product> products;


        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }


        public ProductViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();

        }

        private async void LoadProducts()
        {
            var response = await this.apiService.GetListAsync<Product>(
                "https://shop5erika.azurewebsites.net",
                "/api",
                "/Products");

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;
            }

            var myProducts = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(myProducts);
        }
    }
}
