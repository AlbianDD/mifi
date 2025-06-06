package com.example.zayavki_mobile;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
    public void LogInClick(View v){
        EditText Login = findViewById(R.id.LoginText);
        EditText Password = findViewById(R.id.PasswordText);
        TextView textView = findViewById(R.id.textView);
        if(Login.getText().toString().equals("Albian") && Password.getText().toString().equals("123")){
            Intent intent = new Intent(this, ListActivity.class);
            startActivity(intent);
        } else{
            textView.setText("Неверный логин или пароль");
        }
    }
}