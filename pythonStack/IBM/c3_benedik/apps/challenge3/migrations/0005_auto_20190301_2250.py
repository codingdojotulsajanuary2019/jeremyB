# -*- coding: utf-8 -*-
# Generated by Django 1.10 on 2019-03-01 22:50
from __future__ import unicode_literals

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('challenge3', '0004_user_hash_email'),
    ]

    operations = [
        migrations.AlterField(
            model_name='user',
            name='hash_email',
            field=models.BinaryField(default='$2b$12$CNGgp0CgCijJ4gjVjVn8RO6DqaM6b11GcesJMCewrFaNS./ZJrCLC', max_length=255),
        ),
    ]