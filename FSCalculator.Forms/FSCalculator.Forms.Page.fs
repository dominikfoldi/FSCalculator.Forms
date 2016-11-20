namespace FSCalculator.Forms

open System
open Xamarin.Forms
open Xamarin.Forms.Xaml
open FSCalculator.Calculator
open FSCalculator.CalculatorState
open FSCalculator.InputState

type FSCalculatorFormsPage() = 
    inherit ContentPage()

    let _ = base.LoadFromXaml(typeof<FSCalculatorFormsPage>)

    let historyLabel = base.FindByName<Label>("HistoryLabel")
    let resultLabel = base.FindByName<Label>("ResultLabel")
    do historyLabel.Text <- calculatorState.History
    do resultLabel.Text <- inputState.Input

    let UpdateLabels() =
        historyLabel.Text <- calculatorState.History
        resultLabel.Text <- inputState.Input

    member this.OnClearButtonClicked(sender : Object, args : EventArgs) =
        GetInput Clear
        UpdateLabels()

    member this.OnDeleteButtonClicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput Delete)
        UpdateLabels()

    member this.OnButton0Clicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput (Number 0))
        UpdateLabels() 

    member this.OnButton1Clicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput (Number 1))
        UpdateLabels() 

    member this.OnButton2Clicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput (Number 2))
        UpdateLabels() 

    member this.OnButton3Clicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput (Number 3))
        UpdateLabels() 

    member this.OnButton4Clicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput (Number 4))
        UpdateLabels() 

    member this.OnButton5Clicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput (Number 5))
        UpdateLabels() 

    member this.OnButton6Clicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput (Number 6))
        UpdateLabels() 

    member this.OnButton7Clicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput (Number 7))
        UpdateLabels() 

    member this.OnButton8Clicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput (Number 8))
        UpdateLabels() 

    member this.OnButton9Clicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput (Number 9))
        UpdateLabels() 

    member this.OnEvaluateButtonClicked(sender : Object, args : EventArgs) =
        GetInput (EvaluateInput Evaluate)
        UpdateLabels() 

    member this.OnNegateButtonClicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput Negate)
        UpdateLabels() 

    member this.OnDecimalPointButtonClicked(sender : Object, args : EventArgs) =
        GetInput (NumberInput DecimalPoint)
        UpdateLabels() 

    member this.OnDivideButtonClicked(sender : Object, args : EventArgs) =
        GetInput (EvaluateInput (Operation Divide))
        UpdateLabels() 

    member this.OnMultiplyButtonClicked(sender : Object, args : EventArgs) =
        GetInput (EvaluateInput (Operation Multiply))
        UpdateLabels() 

    member this.OnSubtractButtonClicked(sender : Object, args : EventArgs) =
        GetInput (EvaluateInput (Operation Subtract))
        UpdateLabels() 

    member this.OnAddButtonClicked(sender : Object, args : EventArgs) =
        GetInput (EvaluateInput (Operation Add))
        UpdateLabels() 

type App() = 
    inherit Application(MainPage = FSCalculatorFormsPage())

