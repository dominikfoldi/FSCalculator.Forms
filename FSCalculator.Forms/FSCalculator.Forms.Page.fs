namespace FSCalculator.Forms

open System
open Xamarin.Forms
open Xamarin.Forms.Xaml

type FSCalculatorFormsPage() = 
    inherit ContentPage()

    let _ = base.LoadFromXaml(typeof<FSCalculatorFormsPage>)

    let entry = base.FindByName<Entry>("entry")
    let listView = base.FindByName<ListView>("listView")

    member this.OnCalculateButtonClicked(sender : Object, args : EventArgs) =
        let couldParse, n = Int32.TryParse(entry.Text)
        if (couldParse) then
            let m = (n + 1) / 2 - 2
            do listView.ItemsSource <-
                Array.init(m * m) (fun index -> (index % m + 2) * (index / m + 2))
                |> Set.ofArray
                |> Set.difference (Set.ofArray([| 2..n |]))

type App() = 
    inherit Application(MainPage = FSCalculatorFormsPage())

