﻿using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.PublisherApi
{
	///<summary>
	/// DispatchInterface TextStyles 
	/// SupportByVersion Publisher, 14,15,16
	///</summary>
	[SupportByVersionAttribute("Publisher", 14,15,16)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class TextStyles : COMObject ,IEnumerable<NetOffice.PublisherApi.TextStyle>
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(TextStyles);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public TextStyles(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextStyles(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextStyles(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextStyles(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextStyles(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextStyles() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextStyles(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		public NetOffice.PublisherApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PublisherApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PublisherApi.Application.LateBindingApiWrapperType) as NetOffice.PublisherApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				ICOMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// 
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PublisherApi.TextStyle this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PublisherApi.TextStyle newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PublisherApi.TextStyle.LateBindingApiWrapperType) as NetOffice.PublisherApi.TextStyle;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// 
		/// </summary>
		/// <param name="styleName">string StyleName</param>
		/// <param name="basedOn">optional string BasedOn = </param>
		/// <param name="font">optional NetOffice.PublisherApi.Font Font</param>
		/// <param name="paragraphFormat">optional NetOffice.PublisherApi.ParagraphFormat ParagraphFormat</param>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		public NetOffice.PublisherApi.TextStyle Add(string styleName, object basedOn, object font, object paragraphFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(styleName, basedOn, font, paragraphFormat);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PublisherApi.TextStyle newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PublisherApi.TextStyle.LateBindingApiWrapperType) as NetOffice.PublisherApi.TextStyle;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// 
		/// </summary>
		/// <param name="styleName">string StyleName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		public NetOffice.PublisherApi.TextStyle Add(string styleName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(styleName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PublisherApi.TextStyle newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PublisherApi.TextStyle.LateBindingApiWrapperType) as NetOffice.PublisherApi.TextStyle;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// 
		/// </summary>
		/// <param name="styleName">string StyleName</param>
		/// <param name="basedOn">optional string BasedOn = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		public NetOffice.PublisherApi.TextStyle Add(string styleName, object basedOn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(styleName, basedOn);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PublisherApi.TextStyle newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PublisherApi.TextStyle.LateBindingApiWrapperType) as NetOffice.PublisherApi.TextStyle;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Publisher 14, 15, 16
		/// 
		/// </summary>
		/// <param name="styleName">string StyleName</param>
		/// <param name="basedOn">optional string BasedOn = </param>
		/// <param name="font">optional NetOffice.PublisherApi.Font Font</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		public NetOffice.PublisherApi.TextStyle Add(string styleName, object basedOn, object font)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(styleName, basedOn, font);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PublisherApi.TextStyle newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PublisherApi.TextStyle.LateBindingApiWrapperType) as NetOffice.PublisherApi.TextStyle;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.PublisherApi.TextStyle> Member
        
        /// <summary>
		/// SupportByVersionAttribute Publisher, 14,15,16
		/// </summary>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
       public IEnumerator<NetOffice.PublisherApi.TextStyle> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.PublisherApi.TextStyle item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Publisher, 14,15,16
		/// </summary>
		[SupportByVersionAttribute("Publisher", 14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}