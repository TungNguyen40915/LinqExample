﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CustomerDb")]
	public partial class CustomerDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertCustomerType(CustomerType instance);
    partial void UpdateCustomerType(CustomerType instance);
    partial void DeleteCustomerType(CustomerType instance);
    #endregion
		
		public CustomerDbDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CustomerDbConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CustomerDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CustomerDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CustomerDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CustomerDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<CustomerType> CustomerTypes
		{
			get
			{
				return this.GetTable<CustomerType>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customers")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Name;
		
		private string _PhoneNumber;
		
		private string _Address;
		
		private System.Nullable<System.DateTime> _CreatedDate;
		
		private string _CreateBy;
		
		private System.Nullable<System.DateTime> _ModifiedDate;
		
		private string _ModifiedBy;
		
		private bool _isDeleted;
		
		private System.Nullable<System.Guid> _Type_Id;
		
		private EntityRef<CustomerType> _CustomerType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedDateChanged();
    partial void OnCreateByChanging(string value);
    partial void OnCreateByChanged();
    partial void OnModifiedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedDateChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnisDeletedChanging(bool value);
    partial void OnisDeletedChanged();
    partial void OnType_IdChanging(System.Nullable<System.Guid> value);
    partial void OnType_IdChanged();
    #endregion
		
		public Customer()
		{
			this._CustomerType = default(EntityRef<CustomerType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(MAX)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(MAX)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateBy", DbType="NVarChar(MAX)")]
		public string CreateBy
		{
			get
			{
				return this._CreateBy;
			}
			set
			{
				if ((this._CreateBy != value))
				{
					this.OnCreateByChanging(value);
					this.SendPropertyChanging();
					this._CreateBy = value;
					this.SendPropertyChanged("CreateBy");
					this.OnCreateByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedBy", DbType="NVarChar(MAX)")]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isDeleted", DbType="Bit NOT NULL")]
		public bool isDeleted
		{
			get
			{
				return this._isDeleted;
			}
			set
			{
				if ((this._isDeleted != value))
				{
					this.OnisDeletedChanging(value);
					this.SendPropertyChanging();
					this._isDeleted = value;
					this.SendPropertyChanged("isDeleted");
					this.OnisDeletedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type_Id", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> Type_Id
		{
			get
			{
				return this._Type_Id;
			}
			set
			{
				if ((this._Type_Id != value))
				{
					if (this._CustomerType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnType_IdChanging(value);
					this.SendPropertyChanging();
					this._Type_Id = value;
					this.SendPropertyChanged("Type_Id");
					this.OnType_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CustomerType_Customer", Storage="_CustomerType", ThisKey="Type_Id", OtherKey="Id", IsForeignKey=true)]
		public CustomerType CustomerType
		{
			get
			{
				return this._CustomerType.Entity;
			}
			set
			{
				CustomerType previousValue = this._CustomerType.Entity;
				if (((previousValue != value) 
							|| (this._CustomerType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CustomerType.Entity = null;
						previousValue.Customers.Remove(this);
					}
					this._CustomerType.Entity = value;
					if ((value != null))
					{
						value.Customers.Add(this);
						this._Type_Id = value.Id;
					}
					else
					{
						this._Type_Id = default(Nullable<System.Guid>);
					}
					this.SendPropertyChanged("CustomerType");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CustomerTypes")]
	public partial class CustomerType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Name;
		
		private System.Nullable<System.DateTime> _CreatedDate;
		
		private string _CreateBy;
		
		private System.Nullable<System.DateTime> _ModifiedDate;
		
		private string _ModifiedBy;
		
		private bool _isDeleted;
		
		private EntitySet<Customer> _Customers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedDateChanged();
    partial void OnCreateByChanging(string value);
    partial void OnCreateByChanged();
    partial void OnModifiedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedDateChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    partial void OnisDeletedChanging(bool value);
    partial void OnisDeletedChanged();
    #endregion
		
		public CustomerType()
		{
			this._Customers = new EntitySet<Customer>(new Action<Customer>(this.attach_Customers), new Action<Customer>(this.detach_Customers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateBy", DbType="NVarChar(MAX)")]
		public string CreateBy
		{
			get
			{
				return this._CreateBy;
			}
			set
			{
				if ((this._CreateBy != value))
				{
					this.OnCreateByChanging(value);
					this.SendPropertyChanging();
					this._CreateBy = value;
					this.SendPropertyChanged("CreateBy");
					this.OnCreateByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedBy", DbType="NVarChar(MAX)")]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isDeleted", DbType="Bit NOT NULL")]
		public bool isDeleted
		{
			get
			{
				return this._isDeleted;
			}
			set
			{
				if ((this._isDeleted != value))
				{
					this.OnisDeletedChanging(value);
					this.SendPropertyChanging();
					this._isDeleted = value;
					this.SendPropertyChanged("isDeleted");
					this.OnisDeletedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CustomerType_Customer", Storage="_Customers", ThisKey="Id", OtherKey="Type_Id")]
		public EntitySet<Customer> Customers
		{
			get
			{
				return this._Customers;
			}
			set
			{
				this._Customers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Customers(Customer entity)
		{
			this.SendPropertyChanging();
			entity.CustomerType = this;
		}
		
		private void detach_Customers(Customer entity)
		{
			this.SendPropertyChanging();
			entity.CustomerType = null;
		}
	}
}
#pragma warning restore 1591
