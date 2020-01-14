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

namespace DuomenuBazesFiltravimas
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RobotDataBase")]
	public partial class ConvDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUzsakymai(Uzsakymai instance);
    partial void UpdateUzsakymai(Uzsakymai instance);
    partial void DeleteUzsakymai(Uzsakymai instance);
    partial void InsertSheet(Sheet instance);
    partial void UpdateSheet(Sheet instance);
    partial void DeleteSheet(Sheet instance);
    partial void InsertDrawingInDB(DrawingInDB instance);
    partial void UpdateDrawingInDB(DrawingInDB instance);
    partial void DeleteDrawingInDB(DrawingInDB instance);
    partial void InsertLINESQL(LINESQL instance);
    partial void UpdateLINESQL(LINESQL instance);
    partial void DeleteLINESQL(LINESQL instance);
    #endregion
		
		public ConvDataContext() : 
				base(global::DuomenuBazesFiltravimas.Properties.Settings.Default.RobotDataBaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ConvDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConvDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConvDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConvDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Uzsakymai> Uzsakymais
		{
			get
			{
				return this.GetTable<Uzsakymai>();
			}
		}
		
		public System.Data.Linq.Table<Sheet> Sheets
		{
			get
			{
				return this.GetTable<Sheet>();
			}
		}
		
		public System.Data.Linq.Table<DrawingInDB> DrawingInDBs
		{
			get
			{
				return this.GetTable<DrawingInDB>();
			}
		}
		
		public System.Data.Linq.Table<LINESQL> LINESQLs
		{
			get
			{
				return this.GetTable<LINESQL>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Uzsakymai")]
	public partial class Uzsakymai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private int _Amount;
		
		private System.Nullable<System.DateTime> _DeliveryDate;
		
		private System.Nullable<int> _Priority;
		
		private string _State;
		
		private System.Nullable<int> _AmountDone;
		
		private string _OrderNumber;
		
		private EntitySet<Sheet> _Sheets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAmountChanging(int value);
    partial void OnAmountChanged();
    partial void OnDeliveryDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDeliveryDateChanged();
    partial void OnPriorityChanging(System.Nullable<int> value);
    partial void OnPriorityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnAmountDoneChanging(System.Nullable<int> value);
    partial void OnAmountDoneChanged();
    partial void OnOrderNumberChanging(string value);
    partial void OnOrderNumberChanged();
    #endregion
		
		public Uzsakymai()
		{
			this._Sheets = new EntitySet<Sheet>(new Action<Sheet>(this.attach_Sheets), new Action<Sheet>(this.detach_Sheets));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int NOT NULL")]
		public int Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeliveryDate", DbType="Date")]
		public System.Nullable<System.DateTime> DeliveryDate
		{
			get
			{
				return this._DeliveryDate;
			}
			set
			{
				if ((this._DeliveryDate != value))
				{
					this.OnDeliveryDateChanging(value);
					this.SendPropertyChanging();
					this._DeliveryDate = value;
					this.SendPropertyChanged("DeliveryDate");
					this.OnDeliveryDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Priority", DbType="Int")]
		public System.Nullable<int> Priority
		{
			get
			{
				return this._Priority;
			}
			set
			{
				if ((this._Priority != value))
				{
					this.OnPriorityChanging(value);
					this.SendPropertyChanging();
					this._Priority = value;
					this.SendPropertyChanged("Priority");
					this.OnPriorityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="NVarChar(10)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AmountDone", DbType="Int")]
		public System.Nullable<int> AmountDone
		{
			get
			{
				return this._AmountDone;
			}
			set
			{
				if ((this._AmountDone != value))
				{
					this.OnAmountDoneChanging(value);
					this.SendPropertyChanging();
					this._AmountDone = value;
					this.SendPropertyChanged("AmountDone");
					this.OnAmountDoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderNumber", DbType="NVarChar(MAX)")]
		public string OrderNumber
		{
			get
			{
				return this._OrderNumber;
			}
			set
			{
				if ((this._OrderNumber != value))
				{
					this.OnOrderNumberChanging(value);
					this.SendPropertyChanging();
					this._OrderNumber = value;
					this.SendPropertyChanged("OrderNumber");
					this.OnOrderNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Uzsakymai_Sheet", Storage="_Sheets", ThisKey="Id", OtherKey="UzsakymoID")]
		public EntitySet<Sheet> Sheets
		{
			get
			{
				return this._Sheets;
			}
			set
			{
				this._Sheets.Assign(value);
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
		
		private void attach_Sheets(Sheet entity)
		{
			this.SendPropertyChanging();
			entity.Uzsakymai = this;
		}
		
		private void detach_Sheets(Sheet entity)
		{
			this.SendPropertyChanging();
			entity.Uzsakymai = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sheet")]
	public partial class Sheet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _UzsakymoID;
		
		private System.Nullable<float> _UsedArea;
		
		private System.Nullable<float> _FreeArea;
		
		private System.Nullable<float> _MicroJoint;
		
		private System.Nullable<float> _LengthToMicroJoint;
		
		private int _SL;
		
		private System.Nullable<int> _Priority;
		
		private string _State;
		
		private System.Nullable<int> _Width;
		
		private System.Nullable<int> _Height;
		
		private string _SheetName;
		
		private System.Nullable<int> _Amount;
		
		private System.Nullable<int> _DoneAmount;
		
		private EntitySet<DrawingInDB> _DrawingInDBs;
		
		private EntityRef<Uzsakymai> _Uzsakymai;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUzsakymoIDChanging(System.Nullable<int> value);
    partial void OnUzsakymoIDChanged();
    partial void OnUsedAreaChanging(System.Nullable<float> value);
    partial void OnUsedAreaChanged();
    partial void OnFreeAreaChanging(System.Nullable<float> value);
    partial void OnFreeAreaChanged();
    partial void OnMicroJointChanging(System.Nullable<float> value);
    partial void OnMicroJointChanged();
    partial void OnLengthToMicroJointChanging(System.Nullable<float> value);
    partial void OnLengthToMicroJointChanged();
    partial void OnSLChanging(int value);
    partial void OnSLChanged();
    partial void OnPriorityChanging(System.Nullable<int> value);
    partial void OnPriorityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnWidthChanging(System.Nullable<int> value);
    partial void OnWidthChanged();
    partial void OnHeightChanging(System.Nullable<int> value);
    partial void OnHeightChanged();
    partial void OnSheetNameChanging(string value);
    partial void OnSheetNameChanged();
    partial void OnAmountChanging(System.Nullable<int> value);
    partial void OnAmountChanged();
    partial void OnDoneAmountChanging(System.Nullable<int> value);
    partial void OnDoneAmountChanged();
    #endregion
		
		public Sheet()
		{
			this._DrawingInDBs = new EntitySet<DrawingInDB>(new Action<DrawingInDB>(this.attach_DrawingInDBs), new Action<DrawingInDB>(this.detach_DrawingInDBs));
			this._Uzsakymai = default(EntityRef<Uzsakymai>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UzsakymoID", DbType="Int")]
		public System.Nullable<int> UzsakymoID
		{
			get
			{
				return this._UzsakymoID;
			}
			set
			{
				if ((this._UzsakymoID != value))
				{
					if (this._Uzsakymai.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUzsakymoIDChanging(value);
					this.SendPropertyChanging();
					this._UzsakymoID = value;
					this.SendPropertyChanged("UzsakymoID");
					this.OnUzsakymoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsedArea", DbType="Real")]
		public System.Nullable<float> UsedArea
		{
			get
			{
				return this._UsedArea;
			}
			set
			{
				if ((this._UsedArea != value))
				{
					this.OnUsedAreaChanging(value);
					this.SendPropertyChanging();
					this._UsedArea = value;
					this.SendPropertyChanged("UsedArea");
					this.OnUsedAreaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FreeArea", DbType="Real")]
		public System.Nullable<float> FreeArea
		{
			get
			{
				return this._FreeArea;
			}
			set
			{
				if ((this._FreeArea != value))
				{
					this.OnFreeAreaChanging(value);
					this.SendPropertyChanging();
					this._FreeArea = value;
					this.SendPropertyChanged("FreeArea");
					this.OnFreeAreaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MicroJoint", DbType="Real")]
		public System.Nullable<float> MicroJoint
		{
			get
			{
				return this._MicroJoint;
			}
			set
			{
				if ((this._MicroJoint != value))
				{
					this.OnMicroJointChanging(value);
					this.SendPropertyChanging();
					this._MicroJoint = value;
					this.SendPropertyChanged("MicroJoint");
					this.OnMicroJointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LengthToMicroJoint", DbType="Real")]
		public System.Nullable<float> LengthToMicroJoint
		{
			get
			{
				return this._LengthToMicroJoint;
			}
			set
			{
				if ((this._LengthToMicroJoint != value))
				{
					this.OnLengthToMicroJointChanging(value);
					this.SendPropertyChanging();
					this._LengthToMicroJoint = value;
					this.SendPropertyChanged("LengthToMicroJoint");
					this.OnLengthToMicroJointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SL", DbType="Int NOT NULL")]
		public int SL
		{
			get
			{
				return this._SL;
			}
			set
			{
				if ((this._SL != value))
				{
					this.OnSLChanging(value);
					this.SendPropertyChanging();
					this._SL = value;
					this.SendPropertyChanged("SL");
					this.OnSLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Priority", DbType="Int")]
		public System.Nullable<int> Priority
		{
			get
			{
				return this._Priority;
			}
			set
			{
				if ((this._Priority != value))
				{
					this.OnPriorityChanging(value);
					this.SendPropertyChanging();
					this._Priority = value;
					this.SendPropertyChanged("Priority");
					this.OnPriorityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="NVarChar(50)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Width", DbType="Int")]
		public System.Nullable<int> Width
		{
			get
			{
				return this._Width;
			}
			set
			{
				if ((this._Width != value))
				{
					this.OnWidthChanging(value);
					this.SendPropertyChanging();
					this._Width = value;
					this.SendPropertyChanged("Width");
					this.OnWidthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Height", DbType="Int")]
		public System.Nullable<int> Height
		{
			get
			{
				return this._Height;
			}
			set
			{
				if ((this._Height != value))
				{
					this.OnHeightChanging(value);
					this.SendPropertyChanging();
					this._Height = value;
					this.SendPropertyChanged("Height");
					this.OnHeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SheetName", DbType="NVarChar(50)")]
		public string SheetName
		{
			get
			{
				return this._SheetName;
			}
			set
			{
				if ((this._SheetName != value))
				{
					this.OnSheetNameChanging(value);
					this.SendPropertyChanging();
					this._SheetName = value;
					this.SendPropertyChanged("SheetName");
					this.OnSheetNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int")]
		public System.Nullable<int> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoneAmount", DbType="Int")]
		public System.Nullable<int> DoneAmount
		{
			get
			{
				return this._DoneAmount;
			}
			set
			{
				if ((this._DoneAmount != value))
				{
					this.OnDoneAmountChanging(value);
					this.SendPropertyChanging();
					this._DoneAmount = value;
					this.SendPropertyChanged("DoneAmount");
					this.OnDoneAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sheet_DrawingInDB", Storage="_DrawingInDBs", ThisKey="Id", OtherKey="SheetId")]
		public EntitySet<DrawingInDB> DrawingInDBs
		{
			get
			{
				return this._DrawingInDBs;
			}
			set
			{
				this._DrawingInDBs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Uzsakymai_Sheet", Storage="_Uzsakymai", ThisKey="UzsakymoID", OtherKey="Id", IsForeignKey=true)]
		public Uzsakymai Uzsakymai
		{
			get
			{
				return this._Uzsakymai.Entity;
			}
			set
			{
				Uzsakymai previousValue = this._Uzsakymai.Entity;
				if (((previousValue != value) 
							|| (this._Uzsakymai.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Uzsakymai.Entity = null;
						previousValue.Sheets.Remove(this);
					}
					this._Uzsakymai.Entity = value;
					if ((value != null))
					{
						value.Sheets.Add(this);
						this._UzsakymoID = value.Id;
					}
					else
					{
						this._UzsakymoID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Uzsakymai");
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
		
		private void attach_DrawingInDBs(DrawingInDB entity)
		{
			this.SendPropertyChanging();
			entity.Sheet = this;
		}
		
		private void detach_DrawingInDBs(DrawingInDB entity)
		{
			this.SendPropertyChanging();
			entity.Sheet = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DrawingInDB")]
	public partial class DrawingInDB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _SheetId;
		
		private System.Nullable<int> _PositionX;
		
		private System.Nullable<int> _PositionY;
		
		private System.Nullable<int> _Width;
		
		private System.Nullable<int> _Height;
		
		private System.Nullable<int> _AreaFilled;
		
		private System.Nullable<int> _UzsakymoID;
		
		private string _Code;
		
		private string _Package;
		
		private string _MainItem;
		
		private string _TrueName;
		
		private string _Name;
		
		private System.Nullable<int> _Amount;
		
		private string _NameOfDrawing;
		
		private EntitySet<LINESQL> _LINESQLs;
		
		private EntityRef<Sheet> _Sheet;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSheetIdChanging(System.Nullable<int> value);
    partial void OnSheetIdChanged();
    partial void OnPositionXChanging(System.Nullable<int> value);
    partial void OnPositionXChanged();
    partial void OnPositionYChanging(System.Nullable<int> value);
    partial void OnPositionYChanged();
    partial void OnWidthChanging(System.Nullable<int> value);
    partial void OnWidthChanged();
    partial void OnHeightChanging(System.Nullable<int> value);
    partial void OnHeightChanged();
    partial void OnAreaFilledChanging(System.Nullable<int> value);
    partial void OnAreaFilledChanged();
    partial void OnUzsakymoIDChanging(System.Nullable<int> value);
    partial void OnUzsakymoIDChanged();
    partial void OnCodeChanging(string value);
    partial void OnCodeChanged();
    partial void OnPackageChanging(string value);
    partial void OnPackageChanged();
    partial void OnMainItemChanging(string value);
    partial void OnMainItemChanged();
    partial void OnTrueNameChanging(string value);
    partial void OnTrueNameChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAmountChanging(System.Nullable<int> value);
    partial void OnAmountChanged();
    partial void OnNameOfDrawingChanging(string value);
    partial void OnNameOfDrawingChanged();
    #endregion
		
		public DrawingInDB()
		{
			this._LINESQLs = new EntitySet<LINESQL>(new Action<LINESQL>(this.attach_LINESQLs), new Action<LINESQL>(this.detach_LINESQLs));
			this._Sheet = default(EntityRef<Sheet>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SheetId", DbType="Int")]
		public System.Nullable<int> SheetId
		{
			get
			{
				return this._SheetId;
			}
			set
			{
				if ((this._SheetId != value))
				{
					if (this._Sheet.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSheetIdChanging(value);
					this.SendPropertyChanging();
					this._SheetId = value;
					this.SendPropertyChanged("SheetId");
					this.OnSheetIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionX", DbType="Int")]
		public System.Nullable<int> PositionX
		{
			get
			{
				return this._PositionX;
			}
			set
			{
				if ((this._PositionX != value))
				{
					this.OnPositionXChanging(value);
					this.SendPropertyChanging();
					this._PositionX = value;
					this.SendPropertyChanged("PositionX");
					this.OnPositionXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionY", DbType="Int")]
		public System.Nullable<int> PositionY
		{
			get
			{
				return this._PositionY;
			}
			set
			{
				if ((this._PositionY != value))
				{
					this.OnPositionYChanging(value);
					this.SendPropertyChanging();
					this._PositionY = value;
					this.SendPropertyChanged("PositionY");
					this.OnPositionYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Width", DbType="Int")]
		public System.Nullable<int> Width
		{
			get
			{
				return this._Width;
			}
			set
			{
				if ((this._Width != value))
				{
					this.OnWidthChanging(value);
					this.SendPropertyChanging();
					this._Width = value;
					this.SendPropertyChanged("Width");
					this.OnWidthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Height", DbType="Int")]
		public System.Nullable<int> Height
		{
			get
			{
				return this._Height;
			}
			set
			{
				if ((this._Height != value))
				{
					this.OnHeightChanging(value);
					this.SendPropertyChanging();
					this._Height = value;
					this.SendPropertyChanged("Height");
					this.OnHeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AreaFilled", DbType="Int")]
		public System.Nullable<int> AreaFilled
		{
			get
			{
				return this._AreaFilled;
			}
			set
			{
				if ((this._AreaFilled != value))
				{
					this.OnAreaFilledChanging(value);
					this.SendPropertyChanging();
					this._AreaFilled = value;
					this.SendPropertyChanged("AreaFilled");
					this.OnAreaFilledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UzsakymoID", DbType="Int")]
		public System.Nullable<int> UzsakymoID
		{
			get
			{
				return this._UzsakymoID;
			}
			set
			{
				if ((this._UzsakymoID != value))
				{
					this.OnUzsakymoIDChanging(value);
					this.SendPropertyChanging();
					this._UzsakymoID = value;
					this.SendPropertyChanged("UzsakymoID");
					this.OnUzsakymoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="NVarChar(50)")]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Package", DbType="NVarChar(50)")]
		public string Package
		{
			get
			{
				return this._Package;
			}
			set
			{
				if ((this._Package != value))
				{
					this.OnPackageChanging(value);
					this.SendPropertyChanging();
					this._Package = value;
					this.SendPropertyChanged("Package");
					this.OnPackageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MainItem", DbType="NVarChar(50)")]
		public string MainItem
		{
			get
			{
				return this._MainItem;
			}
			set
			{
				if ((this._MainItem != value))
				{
					this.OnMainItemChanging(value);
					this.SendPropertyChanging();
					this._MainItem = value;
					this.SendPropertyChanged("MainItem");
					this.OnMainItemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrueName", DbType="NVarChar(50)")]
		public string TrueName
		{
			get
			{
				return this._TrueName;
			}
			set
			{
				if ((this._TrueName != value))
				{
					this.OnTrueNameChanging(value);
					this.SendPropertyChanging();
					this._TrueName = value;
					this.SendPropertyChanged("TrueName");
					this.OnTrueNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int")]
		public System.Nullable<int> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameOfDrawing", DbType="NVarChar(50)")]
		public string NameOfDrawing
		{
			get
			{
				return this._NameOfDrawing;
			}
			set
			{
				if ((this._NameOfDrawing != value))
				{
					this.OnNameOfDrawingChanging(value);
					this.SendPropertyChanging();
					this._NameOfDrawing = value;
					this.SendPropertyChanged("NameOfDrawing");
					this.OnNameOfDrawingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DrawingInDB_LINESQL", Storage="_LINESQLs", ThisKey="Id", OtherKey="DrawingIndex")]
		public EntitySet<LINESQL> LINESQLs
		{
			get
			{
				return this._LINESQLs;
			}
			set
			{
				this._LINESQLs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sheet_DrawingInDB", Storage="_Sheet", ThisKey="SheetId", OtherKey="Id", IsForeignKey=true)]
		public Sheet Sheet
		{
			get
			{
				return this._Sheet.Entity;
			}
			set
			{
				Sheet previousValue = this._Sheet.Entity;
				if (((previousValue != value) 
							|| (this._Sheet.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sheet.Entity = null;
						previousValue.DrawingInDBs.Remove(this);
					}
					this._Sheet.Entity = value;
					if ((value != null))
					{
						value.DrawingInDBs.Add(this);
						this._SheetId = value.Id;
					}
					else
					{
						this._SheetId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Sheet");
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
		
		private void attach_LINESQLs(LINESQL entity)
		{
			this.SendPropertyChanging();
			entity.DrawingInDB = this;
		}
		
		private void detach_LINESQLs(LINESQL entity)
		{
			this.SendPropertyChanging();
			entity.DrawingInDB = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LINESQL")]
	public partial class LINESQL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _DrawingIndex;
		
		private System.Nullable<float> _StartX;
		
		private System.Nullable<float> _StartY;
		
		private System.Nullable<float> _EndX;
		
		private System.Nullable<float> _EndY;
		
		private string _Layer;
		
		private System.Nullable<bool> _AddMicroJoint;
		
		private EntityRef<DrawingInDB> _DrawingInDB;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDrawingIndexChanging(int value);
    partial void OnDrawingIndexChanged();
    partial void OnStartXChanging(System.Nullable<float> value);
    partial void OnStartXChanged();
    partial void OnStartYChanging(System.Nullable<float> value);
    partial void OnStartYChanged();
    partial void OnEndXChanging(System.Nullable<float> value);
    partial void OnEndXChanged();
    partial void OnEndYChanging(System.Nullable<float> value);
    partial void OnEndYChanged();
    partial void OnLayerChanging(string value);
    partial void OnLayerChanged();
    partial void OnAddMicroJointChanging(System.Nullable<bool> value);
    partial void OnAddMicroJointChanged();
    #endregion
		
		public LINESQL()
		{
			this._DrawingInDB = default(EntityRef<DrawingInDB>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DrawingIndex", DbType="Int NOT NULL")]
		public int DrawingIndex
		{
			get
			{
				return this._DrawingIndex;
			}
			set
			{
				if ((this._DrawingIndex != value))
				{
					if (this._DrawingInDB.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDrawingIndexChanging(value);
					this.SendPropertyChanging();
					this._DrawingIndex = value;
					this.SendPropertyChanged("DrawingIndex");
					this.OnDrawingIndexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartX", DbType="Real")]
		public System.Nullable<float> StartX
		{
			get
			{
				return this._StartX;
			}
			set
			{
				if ((this._StartX != value))
				{
					this.OnStartXChanging(value);
					this.SendPropertyChanging();
					this._StartX = value;
					this.SendPropertyChanged("StartX");
					this.OnStartXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartY", DbType="Real")]
		public System.Nullable<float> StartY
		{
			get
			{
				return this._StartY;
			}
			set
			{
				if ((this._StartY != value))
				{
					this.OnStartYChanging(value);
					this.SendPropertyChanging();
					this._StartY = value;
					this.SendPropertyChanged("StartY");
					this.OnStartYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndX", DbType="Real")]
		public System.Nullable<float> EndX
		{
			get
			{
				return this._EndX;
			}
			set
			{
				if ((this._EndX != value))
				{
					this.OnEndXChanging(value);
					this.SendPropertyChanging();
					this._EndX = value;
					this.SendPropertyChanged("EndX");
					this.OnEndXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndY", DbType="Real")]
		public System.Nullable<float> EndY
		{
			get
			{
				return this._EndY;
			}
			set
			{
				if ((this._EndY != value))
				{
					this.OnEndYChanging(value);
					this.SendPropertyChanging();
					this._EndY = value;
					this.SendPropertyChanged("EndY");
					this.OnEndYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Layer", DbType="NVarChar(50)")]
		public string Layer
		{
			get
			{
				return this._Layer;
			}
			set
			{
				if ((this._Layer != value))
				{
					this.OnLayerChanging(value);
					this.SendPropertyChanging();
					this._Layer = value;
					this.SendPropertyChanged("Layer");
					this.OnLayerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddMicroJoint", DbType="Bit")]
		public System.Nullable<bool> AddMicroJoint
		{
			get
			{
				return this._AddMicroJoint;
			}
			set
			{
				if ((this._AddMicroJoint != value))
				{
					this.OnAddMicroJointChanging(value);
					this.SendPropertyChanging();
					this._AddMicroJoint = value;
					this.SendPropertyChanged("AddMicroJoint");
					this.OnAddMicroJointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DrawingInDB_LINESQL", Storage="_DrawingInDB", ThisKey="DrawingIndex", OtherKey="Id", IsForeignKey=true)]
		public DrawingInDB DrawingInDB
		{
			get
			{
				return this._DrawingInDB.Entity;
			}
			set
			{
				DrawingInDB previousValue = this._DrawingInDB.Entity;
				if (((previousValue != value) 
							|| (this._DrawingInDB.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DrawingInDB.Entity = null;
						previousValue.LINESQLs.Remove(this);
					}
					this._DrawingInDB.Entity = value;
					if ((value != null))
					{
						value.LINESQLs.Add(this);
						this._DrawingIndex = value.Id;
					}
					else
					{
						this._DrawingIndex = default(int);
					}
					this.SendPropertyChanged("DrawingInDB");
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
