using of Api de Yalidine c# 

        YalidineAPI Y = new YalidineAPI( YalidineApiID,  YalidineToken, YalidineUrl);
        // new YalidineAPI("25911366354855987086", "ng8wza5I3hHkrCBqZRNiJw6v4TUSPemuRAYDIWcMX09cgyTXHmWj23ZKVpjusGFx", "https://api.yalidine.app/v1/");
recuperation de la liste des wilayas:
   YalidineApiClient.Classes.YWilayas yw = await Y.GetWilayasAsync();
 if (yw.Success)
 {
   // Utiliser votre liste des wilaya
 }
 YalidineApiClient.Classes.YCommunes coms = new YCommunes();
 coms = await Y.GetComunesAsync(16);
 la liste des commune de la wilaya 16-Alger
   if (coms.Success)
   {
   //Utiliser la liste des commune
   }
   creation d'un Colis ou des colis 
   YParcelToCreate  ObjYParcelToCreate  = new YParcelToCreate();
                   ObjYParcelToCreate.Address = TxtAddress.Text;
                ObjYParcelToCreate.ContactPhone = TxtContactPhone.Text;
                ObjYParcelToCreate.DeclaredValue = TxtDeclaredValue.IntValue;
                ObjYParcelToCreate.DoInsurance = TxtDoInsurance.Checked;
                ObjYParcelToCreate.Familyname = TxtFamilyname.Text;
                ObjYParcelToCreate.Firstname = TxtFirstname.Text;
                ObjYParcelToCreate.FreeShipping = TxtFreeshipping.Checked;
                ObjYParcelToCreate.FromWilayaName = TxtFromWilayaId.Text;
                if (TxtHasExchange.Checked) ObjYParcelToCreate.HasExchange = 1;
                if (!TxtHasExchange.Checked) ObjYParcelToCreate.HasExchange = 0;
                ObjYParcelToCreate.Height = TxtHeight.IntValue;
                ObjYParcelToCreate.IsStopdesk = TxtIsStopdesk.Checked;
                ObjYParcelToCreate.Length = TxtLength.IntValue;
                ObjYParcelToCreate.OrderId = TxtOrderId.Text = Guid.NewGuid().ToString().ToUpper();
                ObjYParcelToCreate.Price = TxtPrice.IntValue;
                ObjYParcelToCreate.ProductList = TxtProductList.Text;
                ObjYParcelToCreate.ProductToCollect = null;
                ObjYParcelToCreate.ToCommuneName = TxtToCommuneId.Text;
                ObjYParcelToCreate.ToWilayaName = TxtToWilayaId.Text;
                ObjYParcelToCreate.Weight = TxtWeight.IntValue;
                ObjYParcelToCreate.Width = TxtWidth.IntValue;
                YCreateOrdersResults l = await Y.CreateParcel(ObjYParcelToCreate); //creating colis 

            if (l.Success)
           {
             // la liste des colis est cree 
           }
          YCreateOneOrderResult o = new YCreateOneOrderResult();
 if (l.MyYCreateOrderResults.TryGetValue(ObjYParcelToCreate.OrderId, out o))
{
    if (o.Success)
    {
        //recuperation du fichier pdf pour l'imprimer Ylabel
        YLabels L = await Y.GetParcelLabel(o.Label);
      string tempFolder = Path.GetTempPath();
      string fileName = $"Label{o.Tracking}.pdf"; // Name of the file to save
      string filePath = Path.Combine(tempFolder, fileName);
      File.WriteAllBytes(filePath, L.LYLabels[0]);
      System.Diagnostics.Process.Start(filePath); //ouverture du pdf avec le programme par default de lecture des pdf
    }
