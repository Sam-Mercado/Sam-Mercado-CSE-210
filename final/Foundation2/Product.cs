class Product{
        protected string _productName;
        protected int _productID;
        protected int _productPrice;
        protected int _productQuantity;

        public Product(string productName, int productID, int productPrice, int productQuantity){

            _productName = productName;
            _productID = productID;
            _productPrice = productPrice;
            _productQuantity = productQuantity;
        }


        public int GetTotal(){
            
            int total = _productPrice * _productQuantity;
            return total;
        }  



}