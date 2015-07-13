using System;
using LinqToDB.Mapping;
using System.ComponentModel;

namespace MedicalChestProject
{
    [Table]
    public class Drug
    {
        [Browsable(false)]
        [Column(Name="drug_id", IsPrimaryKey=true)]
        public int DrugId { get; set; }

        [Column]
        [DisplayName("Название")]
        public string Name { get; set; }

        [Browsable(false)]
        [Column(Name="storage_id")]
        public int StorageId { get; set; }

        [DisplayName("Место хранения")]
        public string Storage { get; set; }

        [DisplayName("Инфо. о месте хранения")]
        public string StorageInfo { get; set; }

        [Browsable(false)]
        [Column(Name="application_type_id")]
        public int ApplicationTypeId { get; set; }

        [DisplayName("Тип применения")]
        public string ApplicationType { get; set; }

        [Column]
        [DisplayName("Информация")]
        public string Info { get; set; }

        public static Drug Build(Drug drug, Storage storage, ApplicationType appType )
        {
            if(drug!=null)
            {
                drug.ApplicationTypeId = appType.AppTypeId;
                drug.StorageId = storage.StorageId;
                drug.ApplicationType = appType.AppType;
                drug.Storage = storage.Place;
                drug.StorageInfo = storage.Name;
            }
            return drug;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
