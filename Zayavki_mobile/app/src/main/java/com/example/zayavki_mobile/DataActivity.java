package com.example.zayavki_mobile;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class DataActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        String[] arr = {"Телефо\nУронили в ванну с водой", "Телефон\nУронили телефон и разбили экран"};
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_data);
        String info = getIntent().getStringExtra("info");
        TextView textView = findViewById(R.id.textView2);
        if(info == "заявка №1"){
            textView.setText(arr[0]);
        } else{
            textView.setText(arr[1]);
        }
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    public void FinishClick(View v){
        finish();
    }
}