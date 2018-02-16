namespace Sitecore.Support.Data.Fields
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Web;
  using Sitecore.Data.Items;
  using Sitecore.Diagnostics;
  using Sitecore.Links;
  using Sitecore.Data.Fields;

  public class LookupField : Sitecore.Data.Fields.LookupField
  {
    public LookupField(Field innerField) : base(innerField)
    {
    }

    public override void RemoveLink(ItemLink itemLink)
    {
      Assert.ArgumentNotNull(itemLink, "itemLink");
      if (base.TargetID == itemLink.TargetItemID)
      {
        base.Clear();
      }
    }
  }
}