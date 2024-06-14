Imports System.ComponentModel
Imports System.Runtime.InteropServices

''' <summary>
''' Animates a form when it is shown, hidden or closed.
''' </summary>
''' <remarks>
''' MDI child forms do not support the Blend method and only support other methods while being displayed for the first time and when closing.
''' </remarks>
Public NotInheritable Class ModFormAnimator

#Region " Types "

    ''' <summary>
    ''' The methods of animation available.
   ''' </summary>
   ''' 

    Public Enum AnimationMethod
        ''' <summary>
        ''' Rolls out from edge when showing and into edge when hiding.
        ''' </summary>
        ''' <remarks>
        ''' This is the default animation method and requires a direction.
        ''' </remarks>
        Roll = &H0
        ''' <summary>
        ''' Expands out from centre when showing and collapses into centre when hiding.
        ''' </summary>
        Centre = &H10
        ''' <summary>
        ''' Slides out from edge when showing and slides into edge when hiding.
        ''' </summary>
        ''' <remarks>
        ''' Requires a direction.
        ''' </remarks>
        Slide = &H40000
        ''' <summary>
        ''' Fades from transaprent to opaque when showing and from opaque to transparent when hiding.
        ''' </summary>
        Blend = &H80000
    End Enum

    ''' <summary>
    ''' The directions in which the Roll and Slide animations can be shown.
    ''' </summary>
    ''' <remarks>
    ''' Horizontal and vertical directions can be combined to create diagonal animations.
   ''' </remarks>

    <Flags()> Public Enum AnimationDirection
        ''' <summary>
        ''' From left to right.
        ''' </summary>
        Right = &H1
        ''' <summary>
        ''' From right to left.
        ''' </summary>
        Left = &H2
        ''' <summary>
        ''' From top to bottom.
        ''' </summary>
        Down = &H4
        ''' <summary>
        ''' From bottom to top.
        ''' </summary>
        Up = &H8
    End Enum

#End Region 'Types

#Region " Constants "

   ' Hide the form.
    Private Const AW_HIDE As Integer = &H10000
   'Activate the form.
    Private Const AW_ACTIVATE As Integer = &H20000
   ' The number of milliseconds over which the animation occurs if no value is specified.
    Private Const DEFAULT_DURATION As Integer = 250

#End Region 'Constants

#Region " Variables "

   'The form to be animated.
   Private WithEvents _form As Form
   'The animation method used to show and hide the form.
   Private _method As AnimationMethod
   'The direction in which to Roll or Slide the form.
   Private _direction As AnimationDirection
   'The number of milliseconds over which the animation is played.
   Private _duration As Integer

#End Region 'Variables

#Region " Properties "

   ' Gets or sets the animation method used to show and hide the form.
   ' The animation method used to show and hide the form.
   ' Roll is used by default if no method is specified.
   Public Property Method() As AnimationMethod
      Get
         Return Me._method
      End Get
      Set(ByVal Value As AnimationMethod)
         Me._method = Value
      End Set
   End Property

   ''' Gets or sets the direction in which the animation is performed.
   ''' The direction in which the animation is performed.
   ''' The direction is only applicable to the <b>Roll</b> and <b>Slide</b> methods.
   Public Property Direction() As AnimationDirection
      Get
         Return Me._direction
      End Get
      Set(ByVal Value As AnimationDirection)
         Me._direction = Value
      End Set
   End Property


    ''' Gets or sets the number of milliseconds over which the animation is played.
   ''' The number of milliseconds over which the animation is played.
   Public Property Duration() As Integer
      Get
         Return Me._duration
      End Get
      Set(ByVal Value As Integer)
         Me._duration = Value
      End Set
   End Property

   ''' Gets the form to be animated.
   ''' The form to be animated.
   Public ReadOnly Property Form() As Form
      Get
         Return Me._form
      End Get
   End Property

#End Region 'Properties

#Region " APIs "

    ''' <summary>
    ''' Windows API function to animate a window.
    ''' </summary>
    <DllImport("user32")> _
    Private Shared Function AnimateWindow(ByVal hWnd As IntPtr, _
                                          ByVal dwTime As Integer, _
                                          ByVal dwFlags As Integer) As Boolean
    End Function

#End Region 'APIs

#Region " Constructors "

   ''' Creates a new <b></b>FormAnimator object for the specified form.
   ''' The form to be animated.
   ''' No animation will be used unless the <b>Method</b> and/or <b>Direction</b> properties are set independently. The <b>Duration</b> is set to quarter of a second by default.
   Public Sub New(ByVal form As Form)
      Me._form = form
      Me._duration = DEFAULT_DURATION
   End Sub

   ''' Creates a new <b>FormAnimator</b> object for the specified form using the specified method over the specified duration.
   ''' The form to be animated.
   ''' The animation method used to show and hide the form.
   ''' The number of milliseconds over which the animation is played.
   ''' No animation will be used for the <b>Roll</b> or <b>Slide</b> methods unless the <b>Direction</b> property is set independently.
   Public Sub New(ByVal form As Form, ByVal method As AnimationMethod, ByVal duration As Integer)

      Me.New(form)
      Me._method = method
      Me._duration = duration
   End Sub

   ''' Creates a new <b>FormAnimator</b> object for the specified form using the specified method in the specified direction over the specified duration.
   ''' The form to be animated.
   ''' The animation method used to show and hide the form. name="direction">
    ''' The direction in which to animate the form.
   ''' name="duration">
    ''' The number of milliseconds over which the animation is played.
   ''' The <i>direction</i> argument will have no effect if the <b>Centre</b> or <b>Blend</b> method is
   Public Sub New(ByVal form As Form, ByVal method As AnimationMethod, ByVal direction As AnimationDirection, ByVal duration As Integer)

      Me.New(form, method, duration)
      Me._direction = direction
   End Sub

#End Region 'Constructors

#Region " Event Handlers "

   ''' <summary>
   ''' Animates the form automatically when it is loaded.
   ''' </summary>
   Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles _form.Load
      Try
        'MDI child forms do not support transparency so do not try to use the Blend method.
        If Me._form.MdiParent Is Nothing OrElse Me._method <> AnimationMethod.Blend Then
            'Activate the form.
         AnimateWindow(Me._form.Handle, Me._duration, AW_ACTIVATE Or Me._method Or Me._direction)
        End If
      Catch
      End Try
   End Sub

   ''' <summary>
   ''' Animates the form automatically when it is shown or hidden.
   ''' </summary>
   Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _form.VisibleChanged
      Try
         'Do not attempt to animate MDI child forms while showing or hiding as they do not behave as expected.
         If Me._form.MdiParent Is Nothing Then
            Dim flags As Integer = Me._method Or Me._direction

            If Me._form.Visible Then
                  'Activate the form.
                  flags = flags Or AW_ACTIVATE
            Else
                  'Hide the form.
                  flags = flags Or AW_HIDE
            End If
            AnimateWindow(Me._form.Handle, Me._duration, flags)
         End If
      Catch
      End Try
   End Sub

   ''' <summary>
   ''' Animates the form automatically when it closes.
   ''' </summary>
   Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _form.Closing
      Try
        If Not e.Cancel Then
            'MDI child forms do not support transparency so do not try to use the Blend method.
            If Me._form.MdiParent Is Nothing OrElse Me._method <> AnimationMethod.Blend Then
                'Hide the form.
            AnimateWindow(Me._form.Handle, Me._duration, AW_HIDE Or Me._method Or Me._direction)
            End If
        End If
      Catch
      End Try
   End Sub

#End Region 'Event Handlers

End Class
