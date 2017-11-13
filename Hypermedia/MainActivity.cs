using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace Hypermedia
{
    [Activity(Label = "Hypermedia", MainLauncher = true)]
    public class MainActivity : Activity
    {
        #region properties
        private Button loginButton;
        private EditText correoEditText;
        private EditText passwordEditText;
        private const string correo = "buenapregunta@nose.com";
        private const string password = "ChingaTuMadreMarcianito";
        public static ProductosRepo repo;
        #endregion
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            repo = new ProductosRepo();
            loginButton = FindViewById<Button>(Resource.Id.loginButton);
            correoEditText = FindViewById<EditText>(Resource.Id.correoTextEdit);
            passwordEditText = FindViewById<EditText>(Resource.Id.passwordTextEdit);

            loginButton.Click += iniciarSesion;
        }

        void iniciarSesion(object sender, EventArgs ea)
        {
            if (correoEditText.Text == correo && passwordEditText.Text == password)
            {
                var productosActivity = new Intent(this, typeof(productosActivity));
            } else
            {
                Android.Widget.Toast.MakeText(this, "Usuario o contraseña incorrectos", Android.Widget.ToastLength.Short).Show();
            }
        }
    }
}

