<<<<<<< HEAD
<<<<<<< HEAD
﻿#pragma checksum "C:\Users\Luna McClain\Desktop\Class Work Assignments\Introduction to Software Projects\Team-Name-Project\PokeDex\PokeDex\ChoosingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E0D509805885004664D460FA28ADD430"
=======
﻿#pragma checksum "C:\Users\Jacob Mabey\Documents\Intro Software Projects\Team-Name-Project\PokeDex\PokeDex\ChoosingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "046C9ABD249CF03F90A8E607CFBA8994"
>>>>>>> a9481a128bbdd59b016491ed3c632f986306c681
=======
﻿#pragma checksum "C:\Users\Jacob Mabey\Documents\Intro Software Projects\Team-Name-Project\PokeDex\PokeDex\ChoosingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "046C9ABD249CF03F90A8E607CFBA8994"
>>>>>>> a9481a128bbdd59b016491ed3c632f986306c681
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PokeDex
{
    partial class ChoosingPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_Content(global::Windows.UI.Xaml.Controls.ContentControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ChoosingPage_obj10_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IChoosingPage_Bindings
        {
            private global::Pokedata.Pokemon dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj10;

            private ChoosingPage_obj10_BindingsTracking bindingsTracking;

            public ChoosingPage_obj10_Bindings()
            {
                this.bindingsTracking = new ChoosingPage_obj10_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // ChoosingPage.xaml line 49
                        this.obj10 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.ListBoxItem)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj10.Target as global::Windows.UI.Xaml.Controls.ListBoxItem).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Pokedata.Pokemon) item, 1 << phase);
            }

            public void Recycle()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IChoosingPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Pokedata.Pokemon)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Pokedata.Pokemon obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ChoosingPage.xaml line 49
                    if ((this.obj10.Target as global::Windows.UI.Xaml.Controls.ListBoxItem) != null)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content((this.obj10.Target as global::Windows.UI.Xaml.Controls.ListBoxItem), obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ChoosingPage_obj10_BindingsTracking
            {
                private global::System.WeakReference<ChoosingPage_obj10_Bindings> weakRefToBindingObj; 

                public ChoosingPage_obj10_BindingsTracking(ChoosingPage_obj10_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ChoosingPage_obj10_Bindings>(obj);
                }

                public ChoosingPage_obj10_Bindings TryGetBindingObject()
                {
                    ChoosingPage_obj10_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                }

            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ChoosingPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IChoosingPage_Bindings
        {
            private global::PokeDex.ChoosingPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListBox obj7;

            private ChoosingPage_obj1_BindingsTracking bindingsTracking;

            public ChoosingPage_obj1_Bindings()
            {
                this.bindingsTracking = new ChoosingPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // ChoosingPage.xaml line 40
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ListBox)target;
                        break;
                    default:
                        break;
                }
            }

            // IChoosingPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::PokeDex.ChoosingPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::PokeDex.ChoosingPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_pokedex(obj.pokedex, phase);
                    }
                }
            }
            private void Update_pokedex(global::Pokedata.Pokedex obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // ChoosingPage.xaml line 40
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ChoosingPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ChoosingPage_obj1_Bindings> weakRefToBindingObj; 

                public ChoosingPage_obj1_BindingsTracking(ChoosingPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ChoosingPage_obj1_Bindings>(obj);
                }

                public ChoosingPage_obj1_Bindings TryGetBindingObject()
                {
                    ChoosingPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                }

            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // ChoosingPage.xaml line 14
                {
                    this.BackGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // ChoosingPage.xaml line 15
                {
                    this.LeftSide = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // ChoosingPage.xaml line 21
                {
                    this.TitleRect = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 5: // ChoosingPage.xaml line 23
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // ChoosingPage.xaml line 33
                {
                    this.DisplayPokemon = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7: // ChoosingPage.xaml line 40
                {
                    this.PokemonList = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.PokemonList).SelectionChanged += this.PokemonList_SelectionChanged;
                }
                break;
            case 8: // ChoosingPage.xaml line 54
                {
                    this.Controls = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 9: // ChoosingPage.xaml line 60
                {
                    this.SelectPokemon = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SelectPokemon).Click += this.SelectPokemon_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // ChoosingPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ChoosingPage_obj1_Bindings bindings = new ChoosingPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 10: // ChoosingPage.xaml line 49
                {                    
                    global::Windows.UI.Xaml.Controls.ListBoxItem element10 = (global::Windows.UI.Xaml.Controls.ListBoxItem)target;
                    ChoosingPage_obj10_Bindings bindings = new ChoosingPage_obj10_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element10.DataContext);
                    element10.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element10, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element10, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

