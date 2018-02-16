namespace Sitecore.Support.Data.Fields
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Web;
  using Sitecore.Configuration;
  using Sitecore.Data.Items;
  using Sitecore.Diagnostics;
  using Sitecore.Links;
  using Sitecore.Web.UI.HtmlControls.Data;
  using Sitecore.Data.Fields;
  using Sitecore.Data;

  public class ValueLookupField : Sitecore.Data.Fields.ValueLookupField
  {
    public ValueLookupField(Field innerField) : base(innerField)
    {
    }
    public override void RemoveLink(ItemLink itemLink)
    {
      Assert.ArgumentNotNull(itemLink, "itemLink");
      Database database = Factory.GetDatabase(itemLink.TargetDatabaseName);
      Item item = database.GetItem(itemLink.TargetItemID);
      if (item != null && base.Value == item.Name)
      {
        base.Clear();
      }
    }
  }
}