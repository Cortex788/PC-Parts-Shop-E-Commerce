namespace PC_Parts_Shop_E_Commerce.Common
{
    public static class EntityValidations
    {
        /* Category start */
        public const int CategoryNameMinLength = 2;
        public const int CategoryNameMaxLength = 60;

        /* Category end */


        /* Brand start */
        public const int BrandNameMinLength = 2;
        public const int BrandNameMaxLength = 60;
        /* Brand end */

        /* Product start */
         
        public const int ProductNameMinLength = 2;
        public const int ProductNameMaxLength = 150;

        public const int ProductDescriptionMinLength = 10;
        public const int ProductDescriptionMaxLength = 1000;

        public const int ProductPriceMinValue = 0;
        public const decimal ProductPriceMaxValue = decimal.MaxValue;
        /* Product end */

        /* GPU start */

        public const int GPUNameMinLength = 5;
        public const int GPUNameMaxLength = 100;

        /* GPU end */

        /* CPU start */
            
        public const int CPUNameMinLength = 5;
        public const int CPUNameMaxLength = 100;

        /* CPU end */

        /* Motherboard start */

        public const int MotherboardNameMinLength = 2;
        public const int MotherboardNameMaxLength = 100;

        public const int MotherboardChipsetMinLength = 2;
        public const int MotherboardChipsetMaxLength = 20;

        public const int MotherboardSocketMinLength = 2;
        public const int MotherboardSocketMaxLength = 15;

        public const int MotherboardMemorySlotsMinValue = 1;
        public const int MotherboardMemorySlotsMaxValue = 8;

        /* Motherboard end */


    }
}
