using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;


namespace EFGetStarted
{
    public class Country
    {
        public Int32 CountryId { get; set; }
        public String Name { get; set; }


        public virtual ICollection<Product> Product { get; set; }
    }

    public class ProductOptionValue
    {
        public Int32 ProductOptionValueId { get; set; }
        public Int32 ProductId { get; set; }
        public Int32 OptionId { get; set; }
        public Int32 OptionValueId { get; set; }


        [Required]
        public virtual Product Product { get; set; }
        [Required]
        public virtual OptionValue OptionValue { get; set; }
        [Required]
        public virtual Option Option { get; set; }

    }


    public class OptionValue
    {
        public Int32 OptionValueId { get; set; }
        public Int32 OptionId { get; set; }


        [Required]
        public virtual Option Option { get; set; }
        public virtual ICollection<ProductOptionValue> ProductOptionValue { get; set; }
    }

    public class Option
    {
        public Int32 OptionId { get; set; }
        public Int32 ProductTypeId { get; set; }
        public String Name { get; set; }
        
        [Required]
        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<OptionValue> OptionValue { get; set; }
        public virtual ICollection<ProductOptionValue> ProductOptionValue { get; set; }
    }

    public class Brand
    {
        public Int32 BrandId { get; set; }
        public String Name { get; set; }


        public virtual ICollection<BrandModel> BrandModel { get; set; }
    }

    public class BrandModel
    {
        public Int32 BrandModelId { get; set; }
        public Int32 BrandId { get; set; }
        public Int32 ProductTypeId { get; set; }
        public String Name { get; set; }


        [Required]
        public virtual Brand Brand { get; set; }
        [Required]
        public virtual ProductType ProductType { get; set; }
    }

    public class MOption
    {
        public Int32 MOptionId { get; set; }
        public String Name { get; set; }


        public virtual ICollection<ProductTypeMOption> ProductTypeMOption { get; set; }
        public virtual ICollection<ProductMOptionValue> ProductMOptionValue { get; set; }
        public virtual ICollection<MOptionValue> MOptionValue { get; set; }
    }

    public class MOptionValue
    {
        public Int32 MOptionValueId { get; set; }
        public Int32 MOptionId { get; set; }

        [Required]
        public virtual MOption MOption { get; set; }
        public virtual ICollection<ProductTypeMOption> ProductTypeMOption { get; set; }

    }

    public class ProductTypeMOption
    {
        public Int32 ProductTypeMOptionId { get; set; }
        public Int32 ProductTypeId { get; set; }
        public Int32 MOptionId { get; set; }
        public Int32 MOptionValueId { get; set; }


        [Required]
        public virtual ProductType ProductType { get; set; }
        [Required]
        public virtual MOption MOption { get; set; }
        [Required]
        public virtual MOptionValue MOptionValue { get; set; }
    }

public class ProductMOptionValue
    {
        public Int32 ProductMOptionValueId { get; set; }
        public Int32 ProductTypeId { get; set; }
        public Int32 MOptionId { get; set; }


        [Required]
        public virtual ProductType ProductType { get; set; }
        [Required]
        public virtual MOption MOption { get; set; }
    }

    public class ProductType
    {
        public Int32 ProductTypeId { get; set; }
        public Int32 CategoryId { get; set; }
        public String Name { get; set; }

        [Required]
        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductMOptionValue> ProductMOptionValue { get; set; }
        public virtual ICollection<ProductTypeMOption> ProductTypeMOption { get; set; }
        public virtual ICollection<BrandModel> BrandModel { get; set; }
        public virtual ICollection<Option> Option { get; set; }
    }

    public class Category
    {
        public Int32 CategoryId { get; set; }
        public Int32 _lft { get; set; }
        public Int32 _rgt { get; set; }
        public Int32 ParentId { get; set; }
        public Int32 Top { get; set; }
        public Int32 SortOrder { get; set; }
        public Int32 Status { get; set; }


        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductType> ProductType { get; set; }
    }

    public class Market
    {
        public Int32 MarketId { get; set; }
        public String Address { get; set; }
        public String ShopCount { get; set; }
        public Int32 ProductCount { get; set; }
        public String Photo { get; set; }
        public Int32 Status { get; set; }


        public virtual ICollection<Admin> Admin { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }

    
    public class Login 
    {
        public Int32 LoginId { get; set; }
        public String Name { get; set; }
        public String Username { get; set; }
        public Int32 Phone { get; set; }
        public String Email { get; set; }
        public DateTime EmailVerified { get; set; }
        public String Password { get; set; }
        public String RememberToken { get; set; }

    }

    public class Admin
    {
        public Int32 AdminId { get; set; }
        public Int32 ShopId { get; set; }
        public Int32 LoginId { get; set; }

        [Required]
        public virtual Shop Shop { get; set; }
        [Required]
        public virtual Login Login { get; set; }
    }

    public class User
    {
        public Int32 LoginId { get; set; }

        [Required]
        public virtual Login Login { get; set; }
    }

    public class Cart
    {
        public Int32 CartId { get; set; }
        public Int32 UserId { get; set; }

        [Required]
        public virtual User User { get; set; }
    }

    public class CartProduct
    {
        public Int32 ProductId { get; set; }
        public Int32 CartId { get; set; }

        [Required]
        public Int32 Product Product { get; set; }
        [Required]
        public int32 Cart Cart  { get; set; }
    }

    public class Shop
    {
        public Int32 ShopId { get; set; }
        public Int32 MarketId { get; set; }
        public String Name  { get; set; }
        public String Address { get; set; }
        public Int32 ProductTypesCount { get; set; }
        public Int32 ProductCount { get; set; }
        public Int32 Views { get; set; }
        public String Photo { get; set; }
        public Int32 status { get; set; }
        

        [Required]
        public virtual Market Market { get; set; }
        public virtual ICollection<Admin> Admin { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }


    public class Product 
    {
        public Int32 ProductId { get; set; }
        public Int32 ProductTypeId { get; set; }
        public Int32 CategoryId { get; set; }
        public Int32 MarketId { get; set; }
        public Int32 ShopId { get; set; }
        public Int32 CountryId { get; set; }
        public String Name { get; set; }
        public Decimal Price  { get; set; }
        public Decimal DiscountPrice { get; set; }
        public Decimal Discount { get; set; }
        public Int32 Quantity { get; set; }
        public Int32 Views { get; set; }
        public Int32 SortOrder { get; set; }
        public Int32 Likes { get; set; }
        public Int32 Status { get; set; }


        [Required]
        public virtual ProductType ProductType { get; set; }
        [Required]
        public virtual Category Category { get; set; }
        [Required]
        public virtual Shop Shop { get; set; }
        [Required]
        public virtual Market Market { get; set; }
        [Required]
        public virtual Country Country { get; set; }
        public virtual ICollection<ProductOptionValue> ProductOptionValue { get; set; }
    }


}