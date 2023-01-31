﻿using P03AplikacjaPogodaClientAPI.Tools;
using P03AplikacjaPogodaClientAPI.ViewModels.Commands;
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

        private ProductVM selectedProduct;

        public ProductVM SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                OnPropertyChange();
            }
        }

        public ProdcutWindowVM()
        {
            Products = new ObservableCollection<ProductVM>();
            GetPoducts();

            EditCommand = new DelegateCommand(EditProduct, null);
        }

        public void EditProduct()
        {

        }

        


        private async void GetPoducts()
        {
            ProductsApiTool productsApiTool = new ProductsApiTool();
            var products = await productsApiTool.GetProducts();

            foreach (var p in products)
            {
                Products.Add(new ProductVM(p));
            }
        }
    }
}
