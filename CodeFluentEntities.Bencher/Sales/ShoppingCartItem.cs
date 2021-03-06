﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFluentEntities.Bencher.Sales
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 18 March 2014 16:33.
    // Build:1.0.61214.0764
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0764")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, ShoppingCartID={ShoppingCartID}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class ShoppingCartItem : System.ICloneable, System.IComparable, System.IComparable<CodeFluentEntities.Bencher.Sales.ShoppingCartItem>, CodeFluent.Runtime.ICodeFluentEntity, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<CodeFluentEntities.Bencher.Sales.ShoppingCartItem>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private int _shoppingCartItemID = -1;
        
        private string _shoppingCartID = default(string);
        
        private int _quantity = 1;
        
        private System.DateTime _dateCreated = CodeFluentPersistence.DefaultDateTimeValue;
        
        private System.DateTime _modifiedDate = CodeFluentPersistence.DefaultDateTimeValue;
        
        private int _productProductID = -1;
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Production.Product _product = null;
        
        public ShoppingCartItem()
        {
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual string EntityKey
        {
            get
            {
                return this.ShoppingCartItemID.ToString();
            }
            set
            {
                this.ShoppingCartItemID = ((int)(ConvertUtilities.ChangeType(value, typeof(int), -1)));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.ShoppingCartID;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(((int)(-1)))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int ShoppingCartItemID
        {
            get
            {
                return this._shoppingCartItemID;
            }
            set
            {
                this._shoppingCartItemID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ShoppingCartItemID"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string ShoppingCartID
        {
            get
            {
                return this._shoppingCartID;
            }
            set
            {
                this._shoppingCartID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ShoppingCartID"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(((int)(1)))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        public int Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Quantity"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.DateTime))]
        public System.DateTime DateCreated
        {
            get
            {
                return this._dateCreated;
            }
            set
            {
                this._dateCreated = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("DateCreated"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.DateTime))]
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._modifiedDate;
            }
            set
            {
                this._modifiedDate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ModifiedDate"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int ProductProductID
        {
            get
            {
                if (((this._productProductID == -1) 
                            && (this._product != null)))
                {
                    this._productProductID = this._product.ProductID;
                }
                return this._productProductID;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<int>.Default.Equals(value, this.ProductProductID) == true))
                {
                    return;
                }
                this._product = null;
                this._productProductID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Product"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ProductProductID"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Production.Product Product
        {
            get
            {
                if ((this._product == null))
                {
                    this._product = CodeFluentEntities.Bencher.Production.Product.Load(this._productProductID);
                }
                return this._product;
            }
            set
            {
                this._productProductID = -1;
                this._product = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Product"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ProductProductID"));
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event CodeFluent.Runtime.CodeFluentEntityActionEventHandler EntityAction;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Equals(CodeFluentEntities.Bencher.Sales.ShoppingCartItem shoppingCartItem)
        {
            if ((shoppingCartItem == null))
            {
                return false;
            }
            if ((this.ShoppingCartItemID == -1))
            {
                return base.Equals(shoppingCartItem);
            }
            return (this.ShoppingCartItemID.Equals(shoppingCartItem.ShoppingCartItemID) == true);
        }
        
        public override int GetHashCode()
        {
            return this._shoppingCartItemID;
        }
        
        public override bool Equals(object obj)
        {
            CodeFluentEntities.Bencher.Sales.ShoppingCartItem shoppingCartItem = null;
			shoppingCartItem = obj as CodeFluentEntities.Bencher.Sales.ShoppingCartItem;
            return this.Equals(shoppingCartItem);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            CodeFluentEntities.Bencher.Sales.ShoppingCartItem shoppingCartItem = null;
shoppingCartItem = value as CodeFluentEntities.Bencher.Sales.ShoppingCartItem;
            if ((shoppingCartItem == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(shoppingCartItem);
            return localCompareTo;
        }
        
        public virtual int CompareTo(CodeFluentEntities.Bencher.Sales.ShoppingCartItem shoppingCartItem)
        {
            if ((shoppingCartItem == null))
            {
                throw new System.ArgumentNullException("shoppingCartItem");
            }
            int localCompareTo = this.ShoppingCartItemID.CompareTo(shoppingCartItem.ShoppingCartItemID);
            return localCompareTo;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = CodeFluentEntities.Bencher.Resources.Manager.GetStringWithDefault(culture, "CodeFluentEntities.Bencher.Sales.ShoppingCartItem.ExternalValidate", "Type \'CodeFluentEntities.Bencher.Sales.ShoppingCartItem\' cannot be validated.", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        public virtual bool Delete()
        {
            bool ret = false;
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return ret;
            }
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Sales", "ShoppingCartItem", "Delete");
            persistence.AddRawParameter("@ShoppingCartItemID", this.ShoppingCartItemID);
            persistence.ExecuteNonQuery();
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false));
            ret = true;
            return ret;
        }
        
        protected virtual void ReadRecord(System.Data.IDataReader reader, CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                this._shoppingCartItemID = CodeFluentPersistence.GetReaderValue(reader, "ShoppingCartItemID", ((int)(-1)));
                this._shoppingCartID = CodeFluentPersistence.GetReaderValue(reader, "ShoppingCartID", ((string)(default(string))));
                this._quantity = CodeFluentPersistence.GetReaderValue(reader, "Quantity", ((int)(1)));
                this._dateCreated = CodeFluentPersistence.GetReaderValue(reader, "DateCreated", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
                this._modifiedDate = CodeFluentPersistence.GetReaderValue(reader, "ModifiedDate", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
                this.ProductProductID = CodeFluentPersistence.GetReaderValue(reader, "ProductID", ((int)(-1)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
        
        protected virtual void ReadRecordOnSave(System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            this._shoppingCartItemID = CodeFluentPersistence.GetReaderValue(reader, "ShoppingCartItemID", ((int)(-1)));
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Sales.ShoppingCartItem Load(int shoppingCartItemID)
        {
            if ((shoppingCartItemID == -1))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Sales.ShoppingCartItem shoppingCartItem = new CodeFluentEntities.Bencher.Sales.ShoppingCartItem();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Sales", "ShoppingCartItem", "Load");
            persistence.AddRawParameter("@ShoppingCartItemID", shoppingCartItemID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    shoppingCartItem.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    shoppingCartItem.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return shoppingCartItem;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            bool ret = false;
            if ((this.ShoppingCartItemID == -1))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Sales", "ShoppingCartItem", "Load");
            persistence.AddRawParameter("@ShoppingCartItemID", this.ShoppingCartItemID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecord(reader, options);
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    ret = true;
                }
                else
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return ret;
        }
        
        protected virtual bool BaseSave(bool force)
        {
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted))
            {
                this.Delete();
                return false;
            }
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return false;
            }
            CodeFluentPersistence.ThrowIfDeleted(this);
            this.Validate();
            if (((force == false) 
                        && (this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged)))
            {
                return false;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Sales", "ShoppingCartItem", "Save");
            persistence.AddRawParameter("@ShoppingCartItemID", this.ShoppingCartItemID);
            persistence.AddRawParameter("@ShoppingCartID", this.ShoppingCartID);
            persistence.AddRawParameter("@Quantity", this.Quantity);
            persistence.AddRawParameter("@DateCreated", this.DateCreated);
            persistence.AddRawParameter("@ModifiedDate", this.ModifiedDate);
            persistence.AddRawParameter("@ProductID", this.ProductProductID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecordOnSave(reader);
                }
                CodeFluentPersistence.NextResults(reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false));
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        public virtual bool Save()
        {
            bool localSave = this.BaseSave(false);
            return localSave;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(CodeFluentEntities.Bencher.Sales.ShoppingCartItem shoppingCartItem)
        {
            if ((shoppingCartItem == null))
            {
                return false;
            }
            bool ret = shoppingCartItem.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(CodeFluentEntities.Bencher.Sales.ShoppingCartItem shoppingCartItem)
        {
            bool ret = CodeFluentEntities.Bencher.Sales.ShoppingCartItem.Save(shoppingCartItem);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(CodeFluentEntities.Bencher.Sales.ShoppingCartItem shoppingCartItem)
        {
            if ((shoppingCartItem == null))
            {
                return false;
            }
            bool ret = shoppingCartItem.Delete();
            return ret;
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("ShoppingCartItemID=");
            writer.Write(this.ShoppingCartItemID);
            writer.Write(",");
            writer.Write("ShoppingCartID=");
            writer.Write(this.ShoppingCartID);
            writer.Write(",");
            writer.Write("Quantity=");
            writer.Write(this.Quantity);
            writer.Write(",");
            writer.Write("DateCreated=");
            writer.Write(this.DateCreated);
            writer.Write(",");
            writer.Write("ModifiedDate=");
            writer.Write(this.ModifiedDate);
            writer.Write(",");
            writer.Write("Product=");
            if ((this._product != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._product)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_productProductID=");
            writer.Write(this._productProductID);
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Sales.ShoppingCartItem LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Sales.ShoppingCartItem shoppingCartItem;
            int var = ((int)(ConvertUtilities.ChangeType(key, typeof(int), -1)));
            shoppingCartItem = CodeFluentEntities.Bencher.Sales.ShoppingCartItem.Load(var);
            return shoppingCartItem;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public CodeFluentEntities.Bencher.Sales.ShoppingCartItem Clone(bool deep)
        {
            CodeFluentEntities.Bencher.Sales.ShoppingCartItem shoppingCartItem = new CodeFluentEntities.Bencher.Sales.ShoppingCartItem();
            this.CopyTo(shoppingCartItem, deep);
            return shoppingCartItem;
        }
        
        public CodeFluentEntities.Bencher.Sales.ShoppingCartItem Clone()
        {
            CodeFluentEntities.Bencher.Sales.ShoppingCartItem localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("ShoppingCartItemID") == true))
            {
                this.ShoppingCartItemID = ((int)(ConvertUtilities.ChangeType(dict["ShoppingCartItemID"], typeof(int), -1)));
            }
            if ((dict.Contains("DateCreated") == true))
            {
                this.DateCreated = ((System.DateTime)(ConvertUtilities.ChangeType(dict["DateCreated"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            if ((dict.Contains("ModifiedDate") == true))
            {
                this.ModifiedDate = ((System.DateTime)(ConvertUtilities.ChangeType(dict["ModifiedDate"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            if ((dict.Contains("ShoppingCartID") == true))
            {
                this.ShoppingCartID = ((string)(ConvertUtilities.ChangeType(dict["ShoppingCartID"], typeof(string), default(string))));
            }
            if ((dict.Contains("Quantity") == true))
            {
                this.Quantity = ((int)(ConvertUtilities.ChangeType(dict["Quantity"], typeof(int), 1)));
            }
            if ((dict.Contains("ProductProductID") == true))
            {
                this.ProductProductID = ((int)(ConvertUtilities.ChangeType(dict["ProductProductID"], typeof(int), -1)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(CodeFluentEntities.Bencher.Sales.ShoppingCartItem shoppingCartItem, bool deep)
        {
            if ((shoppingCartItem == null))
            {
                throw new System.ArgumentNullException("shoppingCartItem");
            }
            shoppingCartItem.ShoppingCartItemID = this.ShoppingCartItemID;
            shoppingCartItem.DateCreated = this.DateCreated;
            shoppingCartItem.ModifiedDate = this.ModifiedDate;
            shoppingCartItem.ShoppingCartID = this.ShoppingCartID;
            shoppingCartItem.Quantity = this.Quantity;
            shoppingCartItem.ProductProductID = this.ProductProductID;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, shoppingCartItem));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["ShoppingCartItemID"] = this.ShoppingCartItemID;
            dict["DateCreated"] = this.DateCreated;
            dict["ModifiedDate"] = this.ModifiedDate;
            dict["ShoppingCartID"] = this.ShoppingCartID;
            dict["Quantity"] = this.Quantity;
            dict["ProductProductID"] = this.ProductProductID;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
    }
}
