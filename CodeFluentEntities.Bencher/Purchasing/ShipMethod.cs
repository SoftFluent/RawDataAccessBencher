﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFluentEntities.Bencher.Purchasing
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 18 March 2014 16:33.
    // Build:1.0.61214.0764
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0764")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, Name={Name}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class ShipMethod : System.ICloneable, System.IComparable, System.IComparable<CodeFluentEntities.Bencher.Purchasing.ShipMethod>, CodeFluent.Runtime.ICodeFluentEntity, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<CodeFluentEntities.Bencher.Purchasing.ShipMethod>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private int _shipMethodID = -1;
        
        private string _name = default(string);
        
        private decimal _shipBase = 0.00m;
        
        private decimal _shipRate = 0.00m;
        
        private System.Guid _rowguid = CodeFluentPersistence.DefaultGuidValue;
        
        private System.DateTime _modifiedDate = CodeFluentPersistence.DefaultDateTimeValue;
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Purchasing.PurchaseOrderHeaderCollection _purchaseOrderHeaders;
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Sales.SalesOrderHeaderCollection _salesOrderHeaders;
        
        public ShipMethod()
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
                return this.ShipMethodID.ToString();
            }
            set
            {
                this.ShipMethodID = ((int)(ConvertUtilities.ChangeType(value, typeof(int), -1)));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.Name;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(((int)(-1)))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int ShipMethodID
        {
            get
            {
                return this._shipMethodID;
            }
            set
            {
                this._shipMethodID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ShipMethodID"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Name"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(decimal))]
        public decimal ShipBase
        {
            get
            {
                return this._shipBase;
            }
            set
            {
                this._shipBase = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ShipBase"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(decimal))]
        public decimal ShipRate
        {
            get
            {
                return this._shipRate;
            }
            set
            {
                this._shipRate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ShipRate"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.Guid))]
        public System.Guid Rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Rowguid"));
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
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Purchasing.PurchaseOrderHeaderCollection PurchaseOrderHeaders
        {
            get
            {
                if ((this._purchaseOrderHeaders == null))
                {
                    if (((this.ShipMethodID == -1) 
                                || (this.EntityState.Equals(CodeFluent.Runtime.CodeFluentEntityState.Created) == true)))
                    {
                        this._purchaseOrderHeaders = new CodeFluentEntities.Bencher.Purchasing.PurchaseOrderHeaderCollection(this);
                        return this._purchaseOrderHeaders;
                    }
                    this._purchaseOrderHeaders = CodeFluentEntities.Bencher.Purchasing.PurchaseOrderHeaderCollection.LoadByShipMethod(this);
                }
                return this._purchaseOrderHeaders;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Sales.SalesOrderHeaderCollection SalesOrderHeaders
        {
            get
            {
                if ((this._salesOrderHeaders == null))
                {
                    if (((this.ShipMethodID == -1) 
                                || (this.EntityState.Equals(CodeFluent.Runtime.CodeFluentEntityState.Created) == true)))
                    {
                        this._salesOrderHeaders = new CodeFluentEntities.Bencher.Sales.SalesOrderHeaderCollection(null, this, null, null, null);
                        return this._salesOrderHeaders;
                    }
                    this._salesOrderHeaders = CodeFluentEntities.Bencher.Sales.SalesOrderHeaderCollection.LoadByShipMethod(this);
                }
                return this._salesOrderHeaders;
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
        
        public virtual bool Equals(CodeFluentEntities.Bencher.Purchasing.ShipMethod shipMethod)
        {
            if ((shipMethod == null))
            {
                return false;
            }
            if ((this.ShipMethodID == -1))
            {
                return base.Equals(shipMethod);
            }
            return (this.ShipMethodID.Equals(shipMethod.ShipMethodID) == true);
        }
        
        public override int GetHashCode()
        {
            return this._shipMethodID;
        }
        
        public override bool Equals(object obj)
        {
            CodeFluentEntities.Bencher.Purchasing.ShipMethod shipMethod = null;
			shipMethod = obj as CodeFluentEntities.Bencher.Purchasing.ShipMethod;
            return this.Equals(shipMethod);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            CodeFluentEntities.Bencher.Purchasing.ShipMethod shipMethod = null;
shipMethod = value as CodeFluentEntities.Bencher.Purchasing.ShipMethod;
            if ((shipMethod == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(shipMethod);
            return localCompareTo;
        }
        
        public virtual int CompareTo(CodeFluentEntities.Bencher.Purchasing.ShipMethod shipMethod)
        {
            if ((shipMethod == null))
            {
                throw new System.ArgumentNullException("shipMethod");
            }
            int localCompareTo = this.ShipMethodID.CompareTo(shipMethod.ShipMethodID);
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
                    externalValidate = CodeFluentEntities.Bencher.Resources.Manager.GetStringWithDefault(culture, "CodeFluentEntities.Bencher.Purchasing.ShipMethod.ExternalValidate", "Type \'CodeFluentEntities.Bencher.Purchasing.ShipMethod\' cannot be validated.", null);
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
            persistence.CreateStoredProcedureCommand("Purchasing", "ShipMethod", "Delete");
            persistence.AddRawParameter("@ShipMethodID", this.ShipMethodID);
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
                this._shipMethodID = CodeFluentPersistence.GetReaderValue(reader, "ShipMethodID", ((int)(-1)));
                this._name = CodeFluentPersistence.GetReaderValue(reader, "Name", ((string)(default(string))));
                this._shipBase = CodeFluentPersistence.GetReaderValue(reader, "ShipBase", ((decimal)(0.00m)));
                this._shipRate = CodeFluentPersistence.GetReaderValue(reader, "ShipRate", ((decimal)(0.00m)));
                this._rowguid = CodeFluentPersistence.GetReaderValue(reader, "rowguid", ((System.Guid)(CodeFluentPersistence.DefaultGuidValue)));
                this._modifiedDate = CodeFluentPersistence.GetReaderValue(reader, "ModifiedDate", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
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
            this._shipMethodID = CodeFluentPersistence.GetReaderValue(reader, "ShipMethodID", ((int)(-1)));
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Purchasing.ShipMethod Load(int shipMethodID)
        {
            if ((shipMethodID == -1))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Purchasing.ShipMethod shipMethod = new CodeFluentEntities.Bencher.Purchasing.ShipMethod();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Purchasing", "ShipMethod", "Load");
            persistence.AddRawParameter("@ShipMethodID", shipMethodID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    shipMethod.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    shipMethod.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return shipMethod;
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
            if ((this.ShipMethodID == -1))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Purchasing", "ShipMethod", "Load");
            persistence.AddRawParameter("@ShipMethodID", this.ShipMethodID);
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
            persistence.CreateStoredProcedureCommand("Purchasing", "ShipMethod", "Save");
            persistence.AddRawParameter("@ShipMethodID", this.ShipMethodID);
            persistence.AddRawParameter("@Name", this.Name);
            persistence.AddRawParameter("@ShipBase", this.ShipBase);
            persistence.AddRawParameter("@ShipRate", this.ShipRate);
            persistence.AddRawParameter("@rowguid", this.Rowguid);
            persistence.AddRawParameter("@ModifiedDate", this.ModifiedDate);
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
        public static bool Save(CodeFluentEntities.Bencher.Purchasing.ShipMethod shipMethod)
        {
            if ((shipMethod == null))
            {
                return false;
            }
            bool ret = shipMethod.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(CodeFluentEntities.Bencher.Purchasing.ShipMethod shipMethod)
        {
            bool ret = CodeFluentEntities.Bencher.Purchasing.ShipMethod.Save(shipMethod);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(CodeFluentEntities.Bencher.Purchasing.ShipMethod shipMethod)
        {
            if ((shipMethod == null))
            {
                return false;
            }
            bool ret = shipMethod.Delete();
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
            writer.Write("ShipMethodID=");
            writer.Write(this.ShipMethodID);
            writer.Write(",");
            writer.Write("Name=");
            writer.Write(this.Name);
            writer.Write(",");
            writer.Write("ShipBase=");
            writer.Write(this.ShipBase);
            writer.Write(",");
            writer.Write("ShipRate=");
            writer.Write(this.ShipRate);
            writer.Write(",");
            writer.Write("Rowguid=");
            writer.Write(this.Rowguid);
            writer.Write(",");
            writer.Write("ModifiedDate=");
            writer.Write(this.ModifiedDate);
            writer.Write(",");
            writer.Write("PurchaseOrderHeaders=");
            if ((this._purchaseOrderHeaders != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._purchaseOrderHeaders)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("SalesOrderHeaders=");
            if ((this._salesOrderHeaders != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._salesOrderHeaders)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Purchasing.ShipMethod LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Purchasing.ShipMethod shipMethod;
            int var = ((int)(ConvertUtilities.ChangeType(key, typeof(int), -1)));
            shipMethod = CodeFluentEntities.Bencher.Purchasing.ShipMethod.Load(var);
            return shipMethod;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public CodeFluentEntities.Bencher.Purchasing.ShipMethod Clone(bool deep)
        {
            CodeFluentEntities.Bencher.Purchasing.ShipMethod shipMethod = new CodeFluentEntities.Bencher.Purchasing.ShipMethod();
            this.CopyTo(shipMethod, deep);
            return shipMethod;
        }
        
        public CodeFluentEntities.Bencher.Purchasing.ShipMethod Clone()
        {
            CodeFluentEntities.Bencher.Purchasing.ShipMethod localClone = this.Clone(true);
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
            if ((dict.Contains("ShipMethodID") == true))
            {
                this.ShipMethodID = ((int)(ConvertUtilities.ChangeType(dict["ShipMethodID"], typeof(int), -1)));
            }
            if ((dict.Contains("Rowguid") == true))
            {
                this.Rowguid = ((System.Guid)(ConvertUtilities.ChangeType(dict["Rowguid"], typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
            if ((dict.Contains("ModifiedDate") == true))
            {
                this.ModifiedDate = ((System.DateTime)(ConvertUtilities.ChangeType(dict["ModifiedDate"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            if ((dict.Contains("ShipRate") == true))
            {
                this.ShipRate = ((decimal)(ConvertUtilities.ChangeType(dict["ShipRate"], typeof(decimal), 0.00m)));
            }
            if ((dict.Contains("Name") == true))
            {
                this.Name = ((string)(ConvertUtilities.ChangeType(dict["Name"], typeof(string), default(string))));
            }
            if ((dict.Contains("ShipBase") == true))
            {
                this.ShipBase = ((decimal)(ConvertUtilities.ChangeType(dict["ShipBase"], typeof(decimal), 0.00m)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(CodeFluentEntities.Bencher.Purchasing.ShipMethod shipMethod, bool deep)
        {
            if ((shipMethod == null))
            {
                throw new System.ArgumentNullException("shipMethod");
            }
            shipMethod.ShipMethodID = this.ShipMethodID;
            shipMethod.Rowguid = this.Rowguid;
            shipMethod.ModifiedDate = this.ModifiedDate;
            shipMethod.ShipRate = this.ShipRate;
            shipMethod.Name = this.Name;
            shipMethod.ShipBase = this.ShipBase;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, shipMethod));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["ShipMethodID"] = this.ShipMethodID;
            dict["Rowguid"] = this.Rowguid;
            dict["ModifiedDate"] = this.ModifiedDate;
            dict["ShipRate"] = this.ShipRate;
            dict["Name"] = this.Name;
            dict["ShipBase"] = this.ShipBase;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
    }
}
