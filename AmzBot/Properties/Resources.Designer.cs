﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmzBot.Properties {
    using System;
    
    
    /// <summary>
    ///   Yerelleştirilmiş dizeleri aramak gibi işlemler için, türü kesin olarak belirtilmiş kaynak sınıfı.
    /// </summary>
    // Bu sınıf ResGen veya Visual Studio gibi bir araç kullanılarak StronglyTypedResourceBuilder
    // sınıfı tarafından otomatik olarak oluşturuldu.
    // Üye eklemek veya kaldırmak için .ResX dosyanızı düzenleyin ve sonra da ResGen
    // komutunu /str seçeneğiyle yeniden çalıştırın veya VS projenizi yeniden oluşturun.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Bu sınıf tarafından kullanılan, önbelleğe alınmış ResourceManager örneğini döndürür.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AmzBot.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Tümü için geçerli iş parçacığının CurrentUICulture özelliğini geçersiz kular
        ///   CurrentUICulture özelliğini tüm kaynak aramaları için geçersiz kılar.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.
        /// </summary>
        public static System.Drawing.Bitmap amazon {
            get {
                object obj = ResourceManager.GetObject("amazon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   price = document.querySelector(&apos;.a-offscreen&apos;).innerText 
        ///isPrice = price.includes(&apos;$&apos;) 
        ///stockamountButton = document.querySelector(&apos;.a-button.a-button-dropdown.a-button-small&apos;).querySelector(&apos;#a-autoid-0-announce&apos;) 
        ///detailsButton = document.querySelector(&apos;#exports_desktop_qualifiedBuybox_tlc_feature_div &gt; span.a-declarative&apos;) 
        ///
        ///price1 = Number(document.querySelector(&apos;#rightCol&apos;).innerText.split(&apos;\n&apos;)[0].replace(&apos;$&apos;,&apos;&apos;))
        ///priceS = document.querySelector(&apos;#rightCol&apos;).innerText.split(&apos;\n&apos;)[2]
        ///priceS2 =  [dizenin kalan bölümü kesildi]&quot;; benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        public static string AmericaProductPage {
            get {
                return ResourceManager.GetString("AmericaProductPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   /*if( window.location.href != &apos;https://www.amazon.ca/dp/&apos;){    
        ///sellerCount = 0  
        ///pricePart1 = document.querySelector(&apos;#rightCol&apos;).innerText.indexOf(&apos;$&apos;)
        ///resultPrice = document.querySelector(&apos;#rightCol&apos;).innerText.substr(pricePart1).split(&apos;\n&apos;)[0].replace(&apos;$&apos;,&apos;&apos;)
        ///setTimeout(function() {  
        ///  productName = document.querySelector(&apos;#productTitle&apos;).innerText            
        ///  asinCode = &apos;&apos;  
        ///  itemRank = &apos;&apos;      
        ///  list1 = document.querySelector(&apos;#detailBulletsWrapper_feature_div&apos;)  
        ///  list2 = document.querySelector [dizenin kalan bölümü kesildi]&quot;; benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        public static string CanadaProductPage {
            get {
                return ResourceManager.GetString("CanadaProductPage", resourceCulture);
            }
        }
    }
}
