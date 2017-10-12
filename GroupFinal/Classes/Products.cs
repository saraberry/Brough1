﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal
{
    public class Products
    {
        //declaring variables
        private double productPrice;
        private string productType;
        private int productQuantity;

        //empty constructor
        public Products()
        {
            productPrice = 0.0;
            productType = "";
            productQuantity = 0;
        }
        //constructor with all the variables
        public Products(double productPrice, string productType, int productQuantity)
        {
            this.productPrice = productPrice;
            this.productType = productType;
            this.productQuantity = productQuantity;
        }

        //get and sets for all variables
        public double productPrice { get; set; }

        public string productType { get; set; }

        public int productQuantity { get; set; }
    }
}