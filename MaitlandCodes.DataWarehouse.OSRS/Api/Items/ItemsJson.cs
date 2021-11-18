namespace MaitlandCodes.DataWarehouse.OSRS.Api.Items
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ItemsApiResponse
    {
        [JsonProperty("_items")]
        public List<Item> Items { get; set; }

        [JsonProperty("_links")]
        public ItemsApiResponseLinks Links { get; set; }

        [JsonProperty("_meta")]
        public Meta Meta { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("id")]
        public string ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("incomplete")]
        public bool Incomplete { get; set; }

        [JsonProperty("members")]
        public bool Members { get; set; }

        [JsonProperty("tradeable")]
        public bool Tradeable { get; set; }

        [JsonProperty("tradeable_on_ge")]
        public bool TradeableOnGe { get; set; }

        [JsonProperty("stackable")]
        public bool Stackable { get; set; }

        [JsonProperty("stacked")]
        public object Stacked { get; set; }

        [JsonProperty("noted")]
        public bool Noted { get; set; }

        [JsonProperty("noteable")]
        public bool Noteable { get; set; }

        [JsonProperty("linked_id_item")]
        public long? LinkedIdItem { get; set; }

        [JsonProperty("linked_id_noted")]
        public long? LinkedIdNoted { get; set; }

        [JsonProperty("linked_id_placeholder")]
        public long? LinkedIdPlaceholder { get; set; }

        [JsonProperty("placeholder")]
        public bool Placeholder { get; set; }

        [JsonProperty("equipable")]
        public bool Equipable { get; set; }

        [JsonProperty("equipable_by_player")]
        public bool EquipableByPlayer { get; set; }

        [JsonProperty("equipable_weapon")]
        public bool EquipableWeapon { get; set; }

        [JsonProperty("cost")]
        public long Cost { get; set; }

        [JsonProperty("lowalch")]
        public long? Lowalch { get; set; }

        [JsonProperty("highalch")]
        public long? Highalch { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("buy_limit")]
        public long? BuyLimit { get; set; }

        [JsonProperty("quest_item")]
        public bool QuestItem { get; set; }

        [JsonProperty("release_date")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonProperty("duplicate")]
        public bool Duplicate { get; set; }

        [JsonProperty("examine")]
        public string Examine { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("wiki_name")]
        public string WikiName { get; set; }

        [JsonProperty("wiki_url")]
        public Uri WikiUrl { get; set; }

        [JsonProperty("equipment")]
        public object Equipment { get; set; }

        [JsonProperty("weapon")]
        public object Weapon { get; set; }

        [JsonProperty("_created")]
        public string Created { get; set; }

        [JsonProperty("_updated")]
        public string Updated { get; set; }

        [JsonProperty("_etag")]
        public string Etag { get; set; }

        [JsonProperty("_links")]
        public ItemLinks Links { get; set; }
    }

    public partial class ItemLinks
    {
        [JsonProperty("self")]
        public Last Self { get; set; }
    }

    public partial class Last
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public partial class ItemsApiResponseLinks
    {
        [JsonProperty("parent")]
        public Last Parent { get; set; }

        [JsonProperty("self")]
        public Last Self { get; set; }

        [JsonProperty("next")]
        public Last Next { get; set; }

        [JsonProperty("last")]
        public Last Last { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("max_results")]
        public long MaxResults { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }
}
