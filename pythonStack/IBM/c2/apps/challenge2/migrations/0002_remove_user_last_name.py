# Generated by Django 2.0.6 on 2019-01-16 19:58

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('challenge2', '0001_initial'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='user',
            name='last_name',
        ),
    ]
