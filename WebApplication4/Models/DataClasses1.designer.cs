#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertticket(ticket instance);
    partial void Updateticket(ticket instance);
    partial void Deleteticket(ticket instance);
    partial void InserttStatus(tStatus instance);
    partial void UpdatetStatus(tStatus instance);
    partial void DeletetStatus(tStatus instance);
    partial void Inserttrain(train instance);
    partial void Updatetrain(train instance);
    partial void Deletetrain(train instance);
    partial void Inserttcheck(tcheck instance);
    partial void Updatetcheck(tcheck instance);
    partial void Deletetcheck(tcheck instance);
    partial void Insertpassenger(passenger instance);
    partial void Updatepassenger(passenger instance);
    partial void Deletepassenger(passenger instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ticket> tickets
		{
			get
			{
				return this.GetTable<ticket>();
			}
		}
		
		public System.Data.Linq.Table<tStatus> tStatus
		{
			get
			{
				return this.GetTable<tStatus>();
			}
		}
		
		public System.Data.Linq.Table<train> trains
		{
			get
			{
				return this.GetTable<train>();
			}
		}
		
		public System.Data.Linq.Table<tcheck> tchecks
		{
			get
			{
				return this.GetTable<tcheck>();
			}
		}
		
		public System.Data.Linq.Table<passenger> passengers
		{
			get
			{
				return this.GetTable<passenger>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ticket")]
	public partial class ticket : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ticketId;
		
		private string _ticketClass;
		
		private int _ticketPrice;
		
		private string _trainId;
		
		private int _passengerId;
		
		private EntityRef<train> _train;
		
		private EntityRef<passenger> _passenger;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnticketIdChanging(int value);
    partial void OnticketIdChanged();
    partial void OnticketClassChanging(string value);
    partial void OnticketClassChanged();
    partial void OnticketPriceChanging(int value);
    partial void OnticketPriceChanged();
    partial void OntrainIdChanging(string value);
    partial void OntrainIdChanged();
    partial void OnpassengerIdChanging(int value);
    partial void OnpassengerIdChanged();
    #endregion
		
		public ticket()
		{
			this._train = default(EntityRef<train>);
			this._passenger = default(EntityRef<passenger>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ticketId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ticketId
		{
			get
			{
				return this._ticketId;
			}
			set
			{
				if ((this._ticketId != value))
				{
					this.OnticketIdChanging(value);
					this.SendPropertyChanging();
					this._ticketId = value;
					this.SendPropertyChanged("ticketId");
					this.OnticketIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ticketClass", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ticketClass
		{
			get
			{
				return this._ticketClass;
			}
			set
			{
				if ((this._ticketClass != value))
				{
					this.OnticketClassChanging(value);
					this.SendPropertyChanging();
					this._ticketClass = value;
					this.SendPropertyChanged("ticketClass");
					this.OnticketClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ticketPrice", DbType="Int NOT NULL")]
		public int ticketPrice
		{
			get
			{
				return this._ticketPrice;
			}
			set
			{
				if ((this._ticketPrice != value))
				{
					this.OnticketPriceChanging(value);
					this.SendPropertyChanging();
					this._ticketPrice = value;
					this.SendPropertyChanged("ticketPrice");
					this.OnticketPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trainId", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string trainId
		{
			get
			{
				return this._trainId;
			}
			set
			{
				if ((this._trainId != value))
				{
					if (this._train.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntrainIdChanging(value);
					this.SendPropertyChanging();
					this._trainId = value;
					this.SendPropertyChanged("trainId");
					this.OntrainIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passengerId", DbType="Int NOT NULL")]
		public int passengerId
		{
			get
			{
				return this._passengerId;
			}
			set
			{
				if ((this._passengerId != value))
				{
					if (this._passenger.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpassengerIdChanging(value);
					this.SendPropertyChanging();
					this._passengerId = value;
					this.SendPropertyChanged("passengerId");
					this.OnpassengerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="train_ticket", Storage="_train", ThisKey="trainId", OtherKey="trainId", IsForeignKey=true)]
		public train train
		{
			get
			{
				return this._train.Entity;
			}
			set
			{
				train previousValue = this._train.Entity;
				if (((previousValue != value) 
							|| (this._train.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._train.Entity = null;
						previousValue.tickets.Remove(this);
					}
					this._train.Entity = value;
					if ((value != null))
					{
						value.tickets.Add(this);
						this._trainId = value.trainId;
					}
					else
					{
						this._trainId = default(string);
					}
					this.SendPropertyChanged("train");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="passenger_ticket", Storage="_passenger", ThisKey="passengerId", OtherKey="passengerId", IsForeignKey=true)]
		public passenger passenger
		{
			get
			{
				return this._passenger.Entity;
			}
			set
			{
				passenger previousValue = this._passenger.Entity;
				if (((previousValue != value) 
							|| (this._passenger.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._passenger.Entity = null;
						previousValue.tickets.Remove(this);
					}
					this._passenger.Entity = value;
					if ((value != null))
					{
						value.tickets.Add(this);
						this._passengerId = value.passengerId;
					}
					else
					{
						this._passengerId = default(int);
					}
					this.SendPropertyChanged("passenger");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tStatus")]
	public partial class tStatus : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _trainId;
		
		private int _businessSeats;
		
		private int _economySeats;
		
		private EntityRef<train> _train;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntrainIdChanging(string value);
    partial void OntrainIdChanged();
    partial void OnbusinessSeatsChanging(int value);
    partial void OnbusinessSeatsChanged();
    partial void OneconomySeatsChanging(int value);
    partial void OneconomySeatsChanged();
    #endregion
		
		public tStatus()
		{
			this._train = default(EntityRef<train>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trainId", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string trainId
		{
			get
			{
				return this._trainId;
			}
			set
			{
				if ((this._trainId != value))
				{
					if (this._train.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntrainIdChanging(value);
					this.SendPropertyChanging();
					this._trainId = value;
					this.SendPropertyChanged("trainId");
					this.OntrainIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_businessSeats", DbType="Int NOT NULL")]
		public int businessSeats
		{
			get
			{
				return this._businessSeats;
			}
			set
			{
				if ((this._businessSeats != value))
				{
					this.OnbusinessSeatsChanging(value);
					this.SendPropertyChanging();
					this._businessSeats = value;
					this.SendPropertyChanged("businessSeats");
					this.OnbusinessSeatsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_economySeats", DbType="Int NOT NULL")]
		public int economySeats
		{
			get
			{
				return this._economySeats;
			}
			set
			{
				if ((this._economySeats != value))
				{
					this.OneconomySeatsChanging(value);
					this.SendPropertyChanging();
					this._economySeats = value;
					this.SendPropertyChanged("economySeats");
					this.OneconomySeatsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="train_tStatus", Storage="_train", ThisKey="trainId", OtherKey="trainId", IsForeignKey=true)]
		public train train
		{
			get
			{
				return this._train.Entity;
			}
			set
			{
				train previousValue = this._train.Entity;
				if (((previousValue != value) 
							|| (this._train.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._train.Entity = null;
						previousValue.tStatus = null;
					}
					this._train.Entity = value;
					if ((value != null))
					{
						value.tStatus = this;
						this._trainId = value.trainId;
					}
					else
					{
						this._trainId = default(string);
					}
					this.SendPropertyChanged("train");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.train")]
	public partial class train : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _trainId;
		
		private string _trainName;
		
		private string _sourceCity;
		
		private string _destinationCity;
		
		private string _seatsAvailability;
		
		private EntitySet<ticket> _tickets;
		
		private EntityRef<tStatus> _tStatus;
		
		private EntityRef<tcheck> _tcheck;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntrainIdChanging(string value);
    partial void OntrainIdChanged();
    partial void OntrainNameChanging(string value);
    partial void OntrainNameChanged();
    partial void OnsourceCityChanging(string value);
    partial void OnsourceCityChanged();
    partial void OndestinationCityChanging(string value);
    partial void OndestinationCityChanged();
    partial void OnseatsAvailabilityChanging(string value);
    partial void OnseatsAvailabilityChanged();
    #endregion
		
		public train()
		{
			this._tickets = new EntitySet<ticket>(new Action<ticket>(this.attach_tickets), new Action<ticket>(this.detach_tickets));
			this._tStatus = default(EntityRef<tStatus>);
			this._tcheck = default(EntityRef<tcheck>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trainId", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string trainId
		{
			get
			{
				return this._trainId;
			}
			set
			{
				if ((this._trainId != value))
				{
					this.OntrainIdChanging(value);
					this.SendPropertyChanging();
					this._trainId = value;
					this.SendPropertyChanged("trainId");
					this.OntrainIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trainName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string trainName
		{
			get
			{
				return this._trainName;
			}
			set
			{
				if ((this._trainName != value))
				{
					this.OntrainNameChanging(value);
					this.SendPropertyChanging();
					this._trainName = value;
					this.SendPropertyChanged("trainName");
					this.OntrainNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sourceCity", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string sourceCity
		{
			get
			{
				return this._sourceCity;
			}
			set
			{
				if ((this._sourceCity != value))
				{
					this.OnsourceCityChanging(value);
					this.SendPropertyChanging();
					this._sourceCity = value;
					this.SendPropertyChanged("sourceCity");
					this.OnsourceCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_destinationCity", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string destinationCity
		{
			get
			{
				return this._destinationCity;
			}
			set
			{
				if ((this._destinationCity != value))
				{
					this.OndestinationCityChanging(value);
					this.SendPropertyChanging();
					this._destinationCity = value;
					this.SendPropertyChanged("destinationCity");
					this.OndestinationCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_seatsAvailability", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string seatsAvailability
		{
			get
			{
				return this._seatsAvailability;
			}
			set
			{
				if ((this._seatsAvailability != value))
				{
					this.OnseatsAvailabilityChanging(value);
					this.SendPropertyChanging();
					this._seatsAvailability = value;
					this.SendPropertyChanged("seatsAvailability");
					this.OnseatsAvailabilityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="train_ticket", Storage="_tickets", ThisKey="trainId", OtherKey="trainId")]
		public EntitySet<ticket> tickets
		{
			get
			{
				return this._tickets;
			}
			set
			{
				this._tickets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="train_tStatus", Storage="_tStatus", ThisKey="trainId", OtherKey="trainId", IsUnique=true, IsForeignKey=false)]
		public tStatus tStatus
		{
			get
			{
				return this._tStatus.Entity;
			}
			set
			{
				tStatus previousValue = this._tStatus.Entity;
				if (((previousValue != value) 
							|| (this._tStatus.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tStatus.Entity = null;
						previousValue.train = null;
					}
					this._tStatus.Entity = value;
					if ((value != null))
					{
						value.train = this;
					}
					this.SendPropertyChanged("tStatus");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="train_tcheck", Storage="_tcheck", ThisKey="trainId", OtherKey="trainId", IsUnique=true, IsForeignKey=false)]
		public tcheck tcheck
		{
			get
			{
				return this._tcheck.Entity;
			}
			set
			{
				tcheck previousValue = this._tcheck.Entity;
				if (((previousValue != value) 
							|| (this._tcheck.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tcheck.Entity = null;
						previousValue.train = null;
					}
					this._tcheck.Entity = value;
					if ((value != null))
					{
						value.train = this;
					}
					this.SendPropertyChanged("tcheck");
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
		
		private void attach_tickets(ticket entity)
		{
			this.SendPropertyChanging();
			entity.train = this;
		}
		
		private void detach_tickets(ticket entity)
		{
			this.SendPropertyChanging();
			entity.train = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tcheck")]
	public partial class tcheck : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _trainId;
		
		private int _bticket;
		
		private int _eticket;
		
		private EntityRef<train> _train;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntrainIdChanging(string value);
    partial void OntrainIdChanged();
    partial void OnbticketChanging(int value);
    partial void OnbticketChanged();
    partial void OneticketChanging(int value);
    partial void OneticketChanged();
    #endregion
		
		public tcheck()
		{
			this._train = default(EntityRef<train>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trainId", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string trainId
		{
			get
			{
				return this._trainId;
			}
			set
			{
				if ((this._trainId != value))
				{
					if (this._train.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntrainIdChanging(value);
					this.SendPropertyChanging();
					this._trainId = value;
					this.SendPropertyChanged("trainId");
					this.OntrainIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bticket", DbType="Int NOT NULL")]
		public int bticket
		{
			get
			{
				return this._bticket;
			}
			set
			{
				if ((this._bticket != value))
				{
					this.OnbticketChanging(value);
					this.SendPropertyChanging();
					this._bticket = value;
					this.SendPropertyChanged("bticket");
					this.OnbticketChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eticket", DbType="Int NOT NULL")]
		public int eticket
		{
			get
			{
				return this._eticket;
			}
			set
			{
				if ((this._eticket != value))
				{
					this.OneticketChanging(value);
					this.SendPropertyChanging();
					this._eticket = value;
					this.SendPropertyChanged("eticket");
					this.OneticketChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="train_tcheck", Storage="_train", ThisKey="trainId", OtherKey="trainId", IsForeignKey=true)]
		public train train
		{
			get
			{
				return this._train.Entity;
			}
			set
			{
				train previousValue = this._train.Entity;
				if (((previousValue != value) 
							|| (this._train.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._train.Entity = null;
						previousValue.tcheck = null;
					}
					this._train.Entity = value;
					if ((value != null))
					{
						value.tcheck = this;
						this._trainId = value.trainId;
					}
					else
					{
						this._trainId = default(string);
					}
					this.SendPropertyChanged("train");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.passenger")]
	public partial class passenger : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _passengerId;
		
		private string _passnegerName;
		
		private EntitySet<ticket> _tickets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpassengerIdChanging(int value);
    partial void OnpassengerIdChanged();
    partial void OnpassnegerNameChanging(string value);
    partial void OnpassnegerNameChanged();
    #endregion
		
		public passenger()
		{
			this._tickets = new EntitySet<ticket>(new Action<ticket>(this.attach_tickets), new Action<ticket>(this.detach_tickets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passengerId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int passengerId
		{
			get
			{
				return this._passengerId;
			}
			set
			{
				if ((this._passengerId != value))
				{
					this.OnpassengerIdChanging(value);
					this.SendPropertyChanging();
					this._passengerId = value;
					this.SendPropertyChanged("passengerId");
					this.OnpassengerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passnegerName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string passnegerName
		{
			get
			{
				return this._passnegerName;
			}
			set
			{
				if ((this._passnegerName != value))
				{
					this.OnpassnegerNameChanging(value);
					this.SendPropertyChanging();
					this._passnegerName = value;
					this.SendPropertyChanged("passnegerName");
					this.OnpassnegerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="passenger_ticket", Storage="_tickets", ThisKey="passengerId", OtherKey="passengerId")]
		public EntitySet<ticket> tickets
		{
			get
			{
				return this._tickets;
			}
			set
			{
				this._tickets.Assign(value);
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
		
		private void attach_tickets(ticket entity)
		{
			this.SendPropertyChanging();
			entity.passenger = this;
		}
		
		private void detach_tickets(ticket entity)
		{
			this.SendPropertyChanging();
			entity.passenger = null;
		}
	}
}
#pragma warning restore 1591
