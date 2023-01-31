using P03AplikacjaPogodaClientAPI.Tools;
using P03AplikacjaPogodaClientAPI.ViewModels.Commands;
using P05Sklep.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaPogodaClientAPI.ViewModels.ProductViewModel
{
    internal class ProdcutWindowVM : ViewModelBase
    {
        public ObservableCollection<ProductVM> Products { get; set; }


        public DelegateCommand EditCommand { get; set; }
        public DelegateCommand DeleteCommand { get; set; }     
        public DelegateCommand CreateCommand { get; set; }

        private ProductVM selectedProduct = new ProductVM();

        public ProductVM SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                if(value != null)
                    selectedProduct = value;
                
                OnPropertyChange();
            }
        }

        public ProdcutWindowVM()
        {
            Products = new ObservableCollection<ProductVM>();
            GetPoducts();

            EditCommand = new DelegateCommand(EditProduct, null);
            DeleteCommand = new DelegateCommand(DeleteProduct, null);
            CreateCommand = new DelegateCommand(CreateProduct, null);

        }

        public async void CreateProduct()
        {
            ProductsApiTool productsApiTool = new ProductsApiTool();

            var productToCreate = new Product()
            {
              //  Id = selectedProduct.Id,
                Color = selectedProduct.Color,
                Description = selectedProduct.Description,
                Title = selectedProduct.Title,
                ImageUrl = selectedProduct.ImageUrl
            };
            await productsApiTool.CreateProduct(productToCreate);
            GetPoducts();
        }

        public async void DeleteProduct()
        {
            ProductsApiTool productsApiTool = new ProductsApiTool();

            await productsApiTool.DeleteProduct(selectedProduct.Id);
            
            GetPoducts();
            selectedProduct = new ProductVM();
        }

        public async void EditProduct()
        {
            ProductsApiTool productsApiTool = new ProductsApiTool();

            var productToUpdate = new Product()
            {
                Id = selectedProduct.Id,
                Color = selectedProduct.Color,
                Description = selectedProduct.Description,
                Title = selectedProduct.Title,
                ImageUrl = selectedProduct.ImageUrl
            };
            await productsApiTool.UpdateProduct(productToUpdate);
            GetPoducts();
        }

        private async void GetPoducts()
        {
            ProductsApiTool productsApiTool = new ProductsApiTool();
            var products = await productsApiTool.GetProducts();

            Products.Clear();
            foreach (var p in products)
            {
                Products.Add(new ProductVM(p));
            }
        }
    }
}
