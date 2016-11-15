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

namespace LojaCarroRest.Models
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

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LojaRestDB")]
	public partial class LojaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFabricante(Fabricante instance);
    partial void UpdateFabricante(Fabricante instance);
    partial void DeleteFabricante(Fabricante instance);
    partial void InsertVeiculo(Veiculo instance);
    partial void UpdateVeiculo(Veiculo instance);
    partial void DeleteVeiculo(Veiculo instance);
    #endregion
		
		public LojaDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["LojaRestDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LojaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LojaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LojaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LojaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		internal System.Data.Linq.Table<Fabricante> Fabricantes
		{
			get
			{
				return this.GetTable<Fabricante>();
			}
		}
		
		internal System.Data.Linq.Table<Veiculo> Veiculos
		{
			get
			{
				return this.GetTable<Veiculo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fabricante")]
	internal partial class Fabricante : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Descricao;
		
		private EntitySet<Veiculo> _Veiculos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    #endregion
		
		public Fabricante()
		{
			this._Veiculos = new EntitySet<Veiculo>(new Action<Veiculo>(this.attach_Veiculos), new Action<Veiculo>(this.detach_Veiculos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descricao", DbType="VarChar(50)")]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fabricante_Veiculo", Storage="_Veiculos", ThisKey="Id", OtherKey="IdFabricante")]
		public EntitySet<Veiculo> Veiculos
		{
			get
			{
				return this._Veiculos;
			}
			set
			{
				this._Veiculos.Assign(value);
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
		
		private void attach_Veiculos(Veiculo entity)
		{
			this.SendPropertyChanging();
			entity.Fabricante = this;
		}
		
		private void detach_Veiculos(Veiculo entity)
		{
			this.SendPropertyChanging();
			entity.Fabricante = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Veiculo")]
	internal partial class Veiculo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Modelo;
		
		private System.Nullable<int> _Ano;
		
		private System.Nullable<int> _IdFabricante;
		
		private System.Nullable<System.DateTime> _DataCompra;
		
		private System.Nullable<decimal> _ValorCompra;
		
		private System.Nullable<decimal> _PrecoVenda;
		
		private System.Nullable<System.DateTime> _DataVenda;
		
		private System.Nullable<decimal> _ValorVenda;
		
		private EntityRef<Fabricante> _Fabricante;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnModeloChanging(string value);
    partial void OnModeloChanged();
    partial void OnAnoChanging(System.Nullable<int> value);
    partial void OnAnoChanged();
    partial void OnIdFabricanteChanging(System.Nullable<int> value);
    partial void OnIdFabricanteChanged();
    partial void OnDataCompraChanging(System.Nullable<System.DateTime> value);
    partial void OnDataCompraChanged();
    partial void OnValorCompraChanging(System.Nullable<decimal> value);
    partial void OnValorCompraChanged();
    partial void OnPrecoVendaChanging(System.Nullable<decimal> value);
    partial void OnPrecoVendaChanged();
    partial void OnDataVendaChanging(System.Nullable<System.DateTime> value);
    partial void OnDataVendaChanged();
    partial void OnValorVendaChanging(System.Nullable<decimal> value);
    partial void OnValorVendaChanged();
    #endregion
		
		public Veiculo()
		{
			this._Fabricante = default(EntityRef<Fabricante>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modelo", DbType="VarChar(50)")]
		public string Modelo
		{
			get
			{
				return this._Modelo;
			}
			set
			{
				if ((this._Modelo != value))
				{
					this.OnModeloChanging(value);
					this.SendPropertyChanging();
					this._Modelo = value;
					this.SendPropertyChanged("Modelo");
					this.OnModeloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ano", DbType="Int")]
		public System.Nullable<int> Ano
		{
			get
			{
				return this._Ano;
			}
			set
			{
				if ((this._Ano != value))
				{
					this.OnAnoChanging(value);
					this.SendPropertyChanging();
					this._Ano = value;
					this.SendPropertyChanged("Ano");
					this.OnAnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdFabricante", DbType="Int")]
		public System.Nullable<int> IdFabricante
		{
			get
			{
				return this._IdFabricante;
			}
			set
			{
				if ((this._IdFabricante != value))
				{
					if (this._Fabricante.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdFabricanteChanging(value);
					this.SendPropertyChanging();
					this._IdFabricante = value;
					this.SendPropertyChanged("IdFabricante");
					this.OnIdFabricanteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataCompra", DbType="DateTime")]
		public System.Nullable<System.DateTime> DataCompra
		{
			get
			{
				return this._DataCompra;
			}
			set
			{
				if ((this._DataCompra != value))
				{
					this.OnDataCompraChanging(value);
					this.SendPropertyChanging();
					this._DataCompra = value;
					this.SendPropertyChanged("DataCompra");
					this.OnDataCompraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValorCompra", DbType="Money")]
		public System.Nullable<decimal> ValorCompra
		{
			get
			{
				return this._ValorCompra;
			}
			set
			{
				if ((this._ValorCompra != value))
				{
					this.OnValorCompraChanging(value);
					this.SendPropertyChanging();
					this._ValorCompra = value;
					this.SendPropertyChanged("ValorCompra");
					this.OnValorCompraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecoVenda", DbType="Money")]
		public System.Nullable<decimal> PrecoVenda
		{
			get
			{
				return this._PrecoVenda;
			}
			set
			{
				if ((this._PrecoVenda != value))
				{
					this.OnPrecoVendaChanging(value);
					this.SendPropertyChanging();
					this._PrecoVenda = value;
					this.SendPropertyChanged("PrecoVenda");
					this.OnPrecoVendaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataVenda", DbType="DateTime")]
		public System.Nullable<System.DateTime> DataVenda
		{
			get
			{
				return this._DataVenda;
			}
			set
			{
				if ((this._DataVenda != value))
				{
					this.OnDataVendaChanging(value);
					this.SendPropertyChanging();
					this._DataVenda = value;
					this.SendPropertyChanged("DataVenda");
					this.OnDataVendaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValorVenda", DbType="Money")]
		public System.Nullable<decimal> ValorVenda
		{
			get
			{
				return this._ValorVenda;
			}
			set
			{
				if ((this._ValorVenda != value))
				{
					this.OnValorVendaChanging(value);
					this.SendPropertyChanging();
					this._ValorVenda = value;
					this.SendPropertyChanged("ValorVenda");
					this.OnValorVendaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fabricante_Veiculo", Storage="_Fabricante", ThisKey="IdFabricante", OtherKey="Id", IsForeignKey=true)]
		public Fabricante Fabricante
		{
			get
			{
				return this._Fabricante.Entity;
			}
			set
			{
				Fabricante previousValue = this._Fabricante.Entity;
				if (((previousValue != value) 
							|| (this._Fabricante.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Fabricante.Entity = null;
						previousValue.Veiculos.Remove(this);
					}
					this._Fabricante.Entity = value;
					if ((value != null))
					{
						value.Veiculos.Add(this);
						this._IdFabricante = value.Id;
					}
					else
					{
						this._IdFabricante = default(Nullable<int>);
					}
					this.SendPropertyChanged("Fabricante");
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
