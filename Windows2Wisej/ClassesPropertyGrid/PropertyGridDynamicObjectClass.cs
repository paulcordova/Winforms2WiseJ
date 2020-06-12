using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Microsoft.CSharp.RuntimeBinder;
//using System.Runtime.CompilerServices;

namespace Windows2Wisej.ClassesPropertyGrid
{

    public class DynamicBusinessObject : DynamicObject, ICustomTypeDescriptor, INotifyPropertyChanged
    {
        private readonly
            Dictionary<string, object> _dynamicProperties =
            new Dictionary<string, object>();


        // This property returns the number of elements
        // in the inner dictionary.
        public int Count
        {
            get
            {
                return _dynamicProperties.Count;
            }
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            var memberName = binder.Name.ToLower();
            return _dynamicProperties.TryGetValue(memberName, out result);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            var memberName = binder.Name.ToLower();
            _dynamicProperties[memberName] = value;
            NotifyToRefreshAllProperties();
            return true;
        }


        #region Implementation of ICustomTypeDescriptor

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
        {
            return GetProperties(new Attribute[0]);
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            IEnumerable<DynamicPropertyDescriptor> properties = _dynamicProperties
                .Select(pair => new DynamicPropertyDescriptor(this,
                    pair.Key, pair.Value.GetType(), attributes));
            List<DynamicPropertyDescriptor> list = new List<DynamicPropertyDescriptor>();
            foreach (DynamicPropertyDescriptor property in properties)
                list.Add(property);
            return new PropertyDescriptorCollection(list.ToArray());
        }

        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        public string GetClassName()
        {
            return GetType().Name;
        }
        #endregion

        #region Hide not implemented members

        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        public string GetComponentName()
        {
            throw new NotImplementedException();
        }

        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }
        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
            {
                return;
            }

            var eventArgs = new PropertyChangedEventArgs(propertyName);
            PropertyChanged(this, eventArgs);
        }

        private void NotifyToRefreshAllProperties()
        {
            OnPropertyChanged(string.Empty);
        }

        #endregion

        private class DynamicPropertyDescriptor : PropertyDescriptor
        {
            private readonly DynamicBusinessObject _businessObject;
            private readonly Type _propertyType;

            public DynamicPropertyDescriptor(DynamicBusinessObject businessObject,
                string propertyName, Type propertyType, Attribute[] propertyAttributes)
                : base(propertyName, propertyAttributes)
            {
                _businessObject = businessObject;
                _propertyType = propertyType;
            }

            public override bool CanResetValue(object component)
            {
                return true;
            }

            public override object GetValue(object component)
            {
                return _businessObject._dynamicProperties[Name];
            }

            public override void ResetValue(object component)
            {
            }

            public override void SetValue(object component, object value)
            {
                _businessObject._dynamicProperties[Name] = value;
            }

            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }

            public override Type ComponentType
            {
                get { return typeof(DynamicBusinessObject); }
            }

            public override bool IsReadOnly
            {
                get { return false; }
            }

            public override Type PropertyType
            {
                get { return _propertyType; }
            }
        }
    }


    // The class derived from DynamicObject.
    // Used in Sample 6
    public class DynamicDictionary : DynamicObject
    {
        // The inner dictionary.
        Dictionary<string, object> dictionary
            = new Dictionary<string, object>();

        // This property returns the number of elements
        // in the inner dictionary.
        public int Count
        {
            get
            {
                return dictionary.Count;
            }
        }

        // If you try to get a value of a property
        // not defined in the class, this method is called.
        public override bool TryGetMember(
            GetMemberBinder binder, out object result)
        {
            // Converting the property name to lowercase
            // so that property names become case-insensitive.
            string name = binder.Name.ToLower();

            // If the property name is found in a dictionary,
            // set the result parameter to the property value and return true.
            // Otherwise, return false.
            return dictionary.TryGetValue(name, out result);
        }

        // If you try to set a value of a property that is
        // not defined in the class, this method is called.
        public override bool TrySetMember(
            SetMemberBinder binder, object value)
        {
            // Converting the property name to lowercase
            // so that property names become case-insensitive.
            dictionary[binder.Name.ToLower()] = value;

            // You can always add a value to a dictionary,
            // so this method always returns true.
            return true;
        }
    }


}