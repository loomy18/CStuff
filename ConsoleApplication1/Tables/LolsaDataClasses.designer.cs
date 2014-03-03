﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataScript.Tables
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="StatData")]
	public partial class LolsaDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSummonerTable(SummonerTable instance);
    partial void UpdateSummonerTable(SummonerTable instance);
    partial void DeleteSummonerTable(SummonerTable instance);
    #endregion
		
		public LolsaDataClassesDataContext() : 
				base(global::DataScript.Properties.Settings.Default.StatDataConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LolsaDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LolsaDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LolsaDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LolsaDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SummonerTable> SummonerTables
		{
			get
			{
				return this.GetTable<SummonerTable>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.getSummonerIds")]
		public ISingleResult<getSummonerIdsResult> getSummonerIds()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<getSummonerIdsResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SummonerTable")]
	public partial class SummonerTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SummonerId;
		
		private string _Name;
		
		private int _Server;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSummonerIdChanging(int value);
    partial void OnSummonerIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnServerChanging(int value);
    partial void OnServerChanged();
    #endregion
		
		public SummonerTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SummonerId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SummonerId
		{
			get
			{
				return this._SummonerId;
			}
			set
			{
				if ((this._SummonerId != value))
				{
					this.OnSummonerIdChanging(value);
					this.SendPropertyChanging();
					this._SummonerId = value;
					this.SendPropertyChanged("SummonerId");
					this.OnSummonerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Server", DbType="Int NOT NULL")]
		public int Server
		{
			get
			{
				return this._Server;
			}
			set
			{
				if ((this._Server != value))
				{
					this.OnServerChanging(value);
					this.SendPropertyChanging();
					this._Server = value;
					this.SendPropertyChanged("Server");
					this.OnServerChanged();
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
	
	public partial class getSummonerIdsResult
	{
		
		private int _SummonerId;
		
		public getSummonerIdsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SummonerId", DbType="Int NOT NULL")]
		public int SummonerId
		{
			get
			{
				return this._SummonerId;
			}
			set
			{
				if ((this._SummonerId != value))
				{
					this._SummonerId = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
