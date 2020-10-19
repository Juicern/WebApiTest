using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCateringMealconfigGetResponse.
    /// </summary>
    public class OapiCateringMealconfigGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// GroupMealSettingVo
        /// </summary>
        [XmlElement("result")]
        public GroupMealSettingVoDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// MealitemlistDomain Data Structure.
/// </summary>
[Serializable]

public class MealitemlistDomain : TopObject
{
	        /// <summary>
	        /// 送达时间 HH:mm
	        /// </summary>
	        [XmlElement("delivery_time")]
	        public string DeliveryTime { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 点餐项名称
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// AddressvosDomain Data Structure.
/// </summary>
[Serializable]

public class AddressvosDomain : TopObject
{
	        /// <summary>
	        /// 缩略地址，可为空
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 送餐详细地址
	        /// </summary>
	        [XmlElement("address_detail")]
	        public string AddressDetail { get; set; }
	
	        /// <summary>
	        /// 地址id
	        /// </summary>
	        [XmlElement("address_id")]
	        public long AddressId { get; set; }
}

	/// <summary>
/// GroupMealSettingVoDomain Data Structure.
/// </summary>
[Serializable]

public class GroupMealSettingVoDomain : TopObject
{
	        /// <summary>
	        /// 缩略地址，可为空
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 送餐详细地址
	        /// </summary>
	        [XmlElement("address_detail")]
	        public string AddressDetail { get; set; }
	
	        /// <summary>
	        /// 默认地址的id
	        /// </summary>
	        [XmlElement("address_id")]
	        public long AddressId { get; set; }
	
	        /// <summary>
	        /// Addressvos
	        /// </summary>
	        [XmlArray("address_list")]
	        [XmlArrayItem("addressvos")]
	        public List<AddressvosDomain> AddressList { get; set; }
	
	        /// <summary>
	        /// 可点餐时间
	        /// </summary>
	        [XmlArray("coming_meal_day_list")]
	        [XmlArrayItem("string")]
	        public List<string> ComingMealDayList { get; set; }
	
	        /// <summary>
	        /// 企业corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// Mealitemlist
	        /// </summary>
	        [XmlArray("meal_item_list")]
	        [XmlArrayItem("mealitemlist")]
	        public List<MealitemlistDomain> MealItemList { get; set; }
	
	        /// <summary>
	        /// 点餐时间枚举值：2-法定工作日3-双休及节假日4- 每天
	        /// </summary>
	        [XmlElement("meal_time")]
	        public long MealTime { get; set; }
}

    }
}
