//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TTViewer_v0001.Views {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class TItleView : ContentView {
        
        private BoxView boxView;
        
        private Label colorNameLabel;
        
        private Label colorValueLabel;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(TItleView));
            boxView = this.FindByName<BoxView>("boxView");
            colorNameLabel = this.FindByName<Label>("colorNameLabel");
            colorValueLabel = this.FindByName<Label>("colorValueLabel");
        }
    }
}
