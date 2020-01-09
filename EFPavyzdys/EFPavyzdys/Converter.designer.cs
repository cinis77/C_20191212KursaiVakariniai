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

namespace EFPavyzdys
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DuomenuBaze")]
	public partial class ConverterDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKrepseli(Krepseli instance);
    partial void UpdateKrepseli(Krepseli instance);
    partial void DeleteKrepseli(Krepseli instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertPreke(Preke instance);
    partial void UpdatePreke(Preke instance);
    partial void DeletePreke(Preke instance);
    #endregion
		
		public ConverterDataContext() : 
				base(global::EFPavyzdys.Properties.Settings.Default.DuomenuBazeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ConverterDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConverterDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConverterDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConverterDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Krepseli> Krepselis
		{
			get
			{
				return this.GetTable<Krepseli>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Preke> Prekes
		{
			get
			{
				return this.GetTable<Preke>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Krepselis")]
	public partial class Krepseli : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _VartotojoID;
		
		private string _Busena;
		
		private EntitySet<Preke> _Prekes;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnVartotojoIDChanging(System.Nullable<int> value);
    partial void OnVartotojoIDChanged();
    partial void OnBusenaChanging(string value);
    partial void OnBusenaChanged();
    #endregion
		
		public Krepseli()
		{
			this._Prekes = new EntitySet<Preke>(new Action<Preke>(this.attach_Prekes), new Action<Preke>(this.detach_Prekes));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VartotojoID", DbType="Int")]
		public System.Nullable<int> VartotojoID
		{
			get
			{
				return this._VartotojoID;
			}
			set
			{
				if ((this._VartotojoID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnVartotojoIDChanging(value);
					this.SendPropertyChanging();
					this._VartotojoID = value;
					this.SendPropertyChanged("VartotojoID");
					this.OnVartotojoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Busena", DbType="NVarChar(10)")]
		public string Busena
		{
			get
			{
				return this._Busena;
			}
			set
			{
				if ((this._Busena != value))
				{
					this.OnBusenaChanging(value);
					this.SendPropertyChanging();
					this._Busena = value;
					this.SendPropertyChanged("Busena");
					this.OnBusenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Krepseli_Preke", Storage="_Prekes", ThisKey="Id", OtherKey="KrepselioID")]
		public EntitySet<Preke> Prekes
		{
			get
			{
				return this._Prekes;
			}
			set
			{
				this._Prekes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Krepseli", Storage="_User", ThisKey="VartotojoID", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Krepselis.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Krepselis.Add(this);
						this._VartotojoID = value.Id;
					}
					else
					{
						this._VartotojoID = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_Prekes(Preke entity)
		{
			this.SendPropertyChanging();
			entity.Krepseli = this;
		}
		
		private void detach_Prekes(Preke entity)
		{
			this.SendPropertyChanging();
			entity.Krepseli = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Vardas;
		
		private string _Email;
		
		private EntitySet<Krepseli> _Krepselis;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnVardasChanging(string value);
    partial void OnVardasChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public User()
		{
			this._Krepselis = new EntitySet<Krepseli>(new Action<Krepseli>(this.attach_Krepselis), new Action<Krepseli>(this.detach_Krepselis));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vardas", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Vardas
		{
			get
			{
				return this._Vardas;
			}
			set
			{
				if ((this._Vardas != value))
				{
					this.OnVardasChanging(value);
					this.SendPropertyChanging();
					this._Vardas = value;
					this.SendPropertyChanged("Vardas");
					this.OnVardasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Krepseli", Storage="_Krepselis", ThisKey="Id", OtherKey="VartotojoID")]
		public EntitySet<Krepseli> Krepselis
		{
			get
			{
				return this._Krepselis;
			}
			set
			{
				this._Krepselis.Assign(value);
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
		
		private void attach_Krepselis(Krepseli entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Krepselis(Krepseli entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Prekes")]
	public partial class Preke : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _KrepselioID;
		
		private string _Pavadinimas;
		
		private System.Nullable<double> _Kaina;
		
		private System.Nullable<double> _Svoris;
		
		private EntityRef<Krepseli> _Krepseli;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnKrepselioIDChanging(System.Nullable<int> value);
    partial void OnKrepselioIDChanged();
    partial void OnPavadinimasChanging(string value);
    partial void OnPavadinimasChanged();
    partial void OnKainaChanging(System.Nullable<double> value);
    partial void OnKainaChanged();
    partial void OnSvorisChanging(System.Nullable<double> value);
    partial void OnSvorisChanged();
    #endregion
		
		public Preke()
		{
			this._Krepseli = default(EntityRef<Krepseli>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KrepselioID", DbType="Int")]
		public System.Nullable<int> KrepselioID
		{
			get
			{
				return this._KrepselioID;
			}
			set
			{
				if ((this._KrepselioID != value))
				{
					if (this._Krepseli.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnKrepselioIDChanging(value);
					this.SendPropertyChanging();
					this._KrepselioID = value;
					this.SendPropertyChanged("KrepselioID");
					this.OnKrepselioIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pavadinimas", DbType="NVarChar(20)")]
		public string Pavadinimas
		{
			get
			{
				return this._Pavadinimas;
			}
			set
			{
				if ((this._Pavadinimas != value))
				{
					this.OnPavadinimasChanging(value);
					this.SendPropertyChanging();
					this._Pavadinimas = value;
					this.SendPropertyChanged("Pavadinimas");
					this.OnPavadinimasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kaina", DbType="Float")]
		public System.Nullable<double> Kaina
		{
			get
			{
				return this._Kaina;
			}
			set
			{
				if ((this._Kaina != value))
				{
					this.OnKainaChanging(value);
					this.SendPropertyChanging();
					this._Kaina = value;
					this.SendPropertyChanged("Kaina");
					this.OnKainaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Svoris", DbType="Float")]
		public System.Nullable<double> Svoris
		{
			get
			{
				return this._Svoris;
			}
			set
			{
				if ((this._Svoris != value))
				{
					this.OnSvorisChanging(value);
					this.SendPropertyChanging();
					this._Svoris = value;
					this.SendPropertyChanged("Svoris");
					this.OnSvorisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Krepseli_Preke", Storage="_Krepseli", ThisKey="KrepselioID", OtherKey="Id", IsForeignKey=true)]
		public Krepseli Krepseli
		{
			get
			{
				return this._Krepseli.Entity;
			}
			set
			{
				Krepseli previousValue = this._Krepseli.Entity;
				if (((previousValue != value) 
							|| (this._Krepseli.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Krepseli.Entity = null;
						previousValue.Prekes.Remove(this);
					}
					this._Krepseli.Entity = value;
					if ((value != null))
					{
						value.Prekes.Add(this);
						this._KrepselioID = value.Id;
					}
					else
					{
						this._KrepselioID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Krepseli");
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
}
#pragma warning restore 1591
