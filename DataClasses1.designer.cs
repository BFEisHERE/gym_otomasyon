﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sgates_software
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="linqotomasyon")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTable_1(Table_1 instance);
    partial void UpdateTable_1(Table_1 instance);
    partial void DeleteTable_1(Table_1 instance);
    partial void Insertgrupayarları(grupayarları instance);
    partial void Updategrupayarları(grupayarları instance);
    partial void Deletegrupayarları(grupayarları instance);
    partial void Insertzamanlıımesaj(zamanlıımesaj instance);
    partial void Updatezamanlıımesaj(zamanlıımesaj instance);
    partial void Deletezamanlıımesaj(zamanlıımesaj instance);
    partial void Insertyenıuye_db(yenıuye_db instance);
    partial void Updateyenıuye_db(yenıuye_db instance);
    partial void Deleteyenıuye_db(yenıuye_db instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::sgates_software.Properties.Settings.Default.linqotomasyonConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Table_1> Table_1
		{
			get
			{
				return this.GetTable<Table_1>();
			}
		}
		
		public System.Data.Linq.Table<grupayarları> grupayarları
		{
			get
			{
				return this.GetTable<grupayarları>();
			}
		}
		
		public System.Data.Linq.Table<zamanlıımesaj> zamanlıımesaj
		{
			get
			{
				return this.GetTable<zamanlıımesaj>();
			}
		}
		
		public System.Data.Linq.Table<yenıuye_db> yenıuye_db
		{
			get
			{
				return this.GetTable<yenıuye_db>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_1")]
	public partial class Table_1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Kullanıcı_Adı;
		
		private string _Sifre;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnKullanıcı_AdıChanging(string value);
    partial void OnKullanıcı_AdıChanged();
    partial void OnSifreChanging(string value);
    partial void OnSifreChanged();
    #endregion
		
		public Table_1()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kullanıcı_Adı", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Kullanıcı_Adı
		{
			get
			{
				return this._Kullanıcı_Adı;
			}
			set
			{
				if ((this._Kullanıcı_Adı != value))
				{
					this.OnKullanıcı_AdıChanging(value);
					this.SendPropertyChanging();
					this._Kullanıcı_Adı = value;
					this.SendPropertyChanged("Kullanıcı_Adı");
					this.OnKullanıcı_AdıChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sifre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Sifre
		{
			get
			{
				return this._Sifre;
			}
			set
			{
				if ((this._Sifre != value))
				{
					this.OnSifreChanging(value);
					this.SendPropertyChanging();
					this._Sifre = value;
					this.SendPropertyChanged("Sifre");
					this.OnSifreChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.grupayarları")]
	public partial class grupayarları : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _grup_adı;
		
		private string _cınsıyet;
		
		private string _metin;
		
		private int _fiyat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void Ongrup_adıChanging(string value);
    partial void Ongrup_adıChanged();
    partial void OncınsıyetChanging(string value);
    partial void OncınsıyetChanged();
    partial void OnmetinChanging(string value);
    partial void OnmetinChanged();
    partial void OnfiyatChanging(int value);
    partial void OnfiyatChanged();
    #endregion
		
		public grupayarları()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grup_adı", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string grup_adı
		{
			get
			{
				return this._grup_adı;
			}
			set
			{
				if ((this._grup_adı != value))
				{
					this.Ongrup_adıChanging(value);
					this.SendPropertyChanging();
					this._grup_adı = value;
					this.SendPropertyChanged("grup_adı");
					this.Ongrup_adıChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cınsıyet", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string cınsıyet
		{
			get
			{
				return this._cınsıyet;
			}
			set
			{
				if ((this._cınsıyet != value))
				{
					this.OncınsıyetChanging(value);
					this.SendPropertyChanging();
					this._cınsıyet = value;
					this.SendPropertyChanged("cınsıyet");
					this.OncınsıyetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_metin", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string metin
		{
			get
			{
				return this._metin;
			}
			set
			{
				if ((this._metin != value))
				{
					this.OnmetinChanging(value);
					this.SendPropertyChanging();
					this._metin = value;
					this.SendPropertyChanged("metin");
					this.OnmetinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fiyat", DbType="Int NOT NULL")]
		public int fiyat
		{
			get
			{
				return this._fiyat;
			}
			set
			{
				if ((this._fiyat != value))
				{
					this.OnfiyatChanging(value);
					this.SendPropertyChanging();
					this._fiyat = value;
					this.SendPropertyChanged("fiyat");
					this.OnfiyatChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.zamanlıımesaj")]
	public partial class zamanlıımesaj : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _mesaj;
		
		private string _emaıl;
		
		private string _tarıh;
		
		private string _baslık;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnmesajChanging(string value);
    partial void OnmesajChanged();
    partial void OnemaılChanging(string value);
    partial void OnemaılChanged();
    partial void OntarıhChanging(string value);
    partial void OntarıhChanged();
    partial void OnbaslıkChanging(string value);
    partial void OnbaslıkChanged();
    #endregion
		
		public zamanlıımesaj()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mesaj", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string mesaj
		{
			get
			{
				return this._mesaj;
			}
			set
			{
				if ((this._mesaj != value))
				{
					this.OnmesajChanging(value);
					this.SendPropertyChanging();
					this._mesaj = value;
					this.SendPropertyChanged("mesaj");
					this.OnmesajChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emaıl", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string emaıl
		{
			get
			{
				return this._emaıl;
			}
			set
			{
				if ((this._emaıl != value))
				{
					this.OnemaılChanging(value);
					this.SendPropertyChanging();
					this._emaıl = value;
					this.SendPropertyChanged("emaıl");
					this.OnemaılChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tarıh", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tarıh
		{
			get
			{
				return this._tarıh;
			}
			set
			{
				if ((this._tarıh != value))
				{
					this.OntarıhChanging(value);
					this.SendPropertyChanging();
					this._tarıh = value;
					this.SendPropertyChanged("tarıh");
					this.OntarıhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_baslık", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string baslık
		{
			get
			{
				return this._baslık;
			}
			set
			{
				if ((this._baslık != value))
				{
					this.OnbaslıkChanging(value);
					this.SendPropertyChanging();
					this._baslık = value;
					this.SendPropertyChanged("baslık");
					this.OnbaslıkChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.yenıuye_db")]
	public partial class yenıuye_db : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _mno;
		
		private string _ad;
		
		private string _soyad;
		
		private string _tcno;
		
		private string _telno;
		
		private string _cınsıyet;
		
		private decimal _grup;
		
		private string _bas_tarıh;
		
		private string _bıt_tarıh;
		
		private string _emaıl;
		
		private string _ıl;
		
		private string _ılce;
		
		private string _adres;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmnoChanging(int value);
    partial void OnmnoChanged();
    partial void OnadChanging(string value);
    partial void OnadChanged();
    partial void OnsoyadChanging(string value);
    partial void OnsoyadChanged();
    partial void OntcnoChanging(string value);
    partial void OntcnoChanged();
    partial void OntelnoChanging(string value);
    partial void OntelnoChanged();
    partial void OncınsıyetChanging(string value);
    partial void OncınsıyetChanged();
    partial void OngrupChanging(decimal value);
    partial void OngrupChanged();
    partial void Onbas_tarıhChanging(string value);
    partial void Onbas_tarıhChanged();
    partial void Onbıt_tarıhChanging(string value);
    partial void Onbıt_tarıhChanged();
    partial void OnemaılChanging(string value);
    partial void OnemaılChanged();
    partial void OnılChanging(string value);
    partial void OnılChanged();
    partial void OnılceChanging(string value);
    partial void OnılceChanged();
    partial void OnadresChanging(string value);
    partial void OnadresChanged();
    #endregion
		
		public yenıuye_db()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mno", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int mno
		{
			get
			{
				return this._mno;
			}
			set
			{
				if ((this._mno != value))
				{
					this.OnmnoChanging(value);
					this.SendPropertyChanging();
					this._mno = value;
					this.SendPropertyChanged("mno");
					this.OnmnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ad
		{
			get
			{
				return this._ad;
			}
			set
			{
				if ((this._ad != value))
				{
					this.OnadChanging(value);
					this.SendPropertyChanging();
					this._ad = value;
					this.SendPropertyChanged("ad");
					this.OnadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soyad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string soyad
		{
			get
			{
				return this._soyad;
			}
			set
			{
				if ((this._soyad != value))
				{
					this.OnsoyadChanging(value);
					this.SendPropertyChanging();
					this._soyad = value;
					this.SendPropertyChanged("soyad");
					this.OnsoyadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tcno", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tcno
		{
			get
			{
				return this._tcno;
			}
			set
			{
				if ((this._tcno != value))
				{
					this.OntcnoChanging(value);
					this.SendPropertyChanging();
					this._tcno = value;
					this.SendPropertyChanged("tcno");
					this.OntcnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telno", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string telno
		{
			get
			{
				return this._telno;
			}
			set
			{
				if ((this._telno != value))
				{
					this.OntelnoChanging(value);
					this.SendPropertyChanging();
					this._telno = value;
					this.SendPropertyChanged("telno");
					this.OntelnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cınsıyet", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string cınsıyet
		{
			get
			{
				return this._cınsıyet;
			}
			set
			{
				if ((this._cınsıyet != value))
				{
					this.OncınsıyetChanging(value);
					this.SendPropertyChanging();
					this._cınsıyet = value;
					this.SendPropertyChanged("cınsıyet");
					this.OncınsıyetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grup", DbType="Decimal(18,2) NOT NULL")]
		public decimal grup
		{
			get
			{
				return this._grup;
			}
			set
			{
				if ((this._grup != value))
				{
					this.OngrupChanging(value);
					this.SendPropertyChanging();
					this._grup = value;
					this.SendPropertyChanged("grup");
					this.OngrupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bas_tarıh", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string bas_tarıh
		{
			get
			{
				return this._bas_tarıh;
			}
			set
			{
				if ((this._bas_tarıh != value))
				{
					this.Onbas_tarıhChanging(value);
					this.SendPropertyChanging();
					this._bas_tarıh = value;
					this.SendPropertyChanged("bas_tarıh");
					this.Onbas_tarıhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bıt_tarıh", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string bıt_tarıh
		{
			get
			{
				return this._bıt_tarıh;
			}
			set
			{
				if ((this._bıt_tarıh != value))
				{
					this.Onbıt_tarıhChanging(value);
					this.SendPropertyChanging();
					this._bıt_tarıh = value;
					this.SendPropertyChanged("bıt_tarıh");
					this.Onbıt_tarıhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emaıl", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string emaıl
		{
			get
			{
				return this._emaıl;
			}
			set
			{
				if ((this._emaıl != value))
				{
					this.OnemaılChanging(value);
					this.SendPropertyChanging();
					this._emaıl = value;
					this.SendPropertyChanged("emaıl");
					this.OnemaılChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ıl", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ıl
		{
			get
			{
				return this._ıl;
			}
			set
			{
				if ((this._ıl != value))
				{
					this.OnılChanging(value);
					this.SendPropertyChanging();
					this._ıl = value;
					this.SendPropertyChanged("ıl");
					this.OnılChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ılce", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ılce
		{
			get
			{
				return this._ılce;
			}
			set
			{
				if ((this._ılce != value))
				{
					this.OnılceChanging(value);
					this.SendPropertyChanging();
					this._ılce = value;
					this.SendPropertyChanged("ılce");
					this.OnılceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adres", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string adres
		{
			get
			{
				return this._adres;
			}
			set
			{
				if ((this._adres != value))
				{
					this.OnadresChanging(value);
					this.SendPropertyChanging();
					this._adres = value;
					this.SendPropertyChanged("adres");
					this.OnadresChanged();
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
