PGDMP         8                y            postgres    13.2    13.2 
    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    13442    postgres    DATABASE     h   CREATE DATABASE postgres WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Portuguese_Brazil.1252';
    DROP DATABASE postgres;
                postgres    false            �           0    0    DATABASE postgres    COMMENT     N   COMMENT ON DATABASE postgres IS 'default administrative connection database';
                   postgres    false    2988                        3079    16384 	   adminpack 	   EXTENSION     A   CREATE EXTENSION IF NOT EXISTS adminpack WITH SCHEMA pg_catalog;
    DROP EXTENSION adminpack;
                   false            �           0    0    EXTENSION adminpack    COMMENT     M   COMMENT ON EXTENSION adminpack IS 'administrative functions for PostgreSQL';
                        false    2            �            1259    16403    login    TABLE        CREATE TABLE public.login (
    userid integer NOT NULL,
    username character varying,
    userpassword character varying
);
    DROP TABLE public.login;
       public         heap    postgres    false            �          0    16403    login 
   TABLE DATA           ?   COPY public.login (userid, username, userpassword) FROM stdin;
    public          postgres    false    201   �       #           2606    16410    login useridpk 
   CONSTRAINT     P   ALTER TABLE ONLY public.login
    ADD CONSTRAINT useridpk PRIMARY KEY (userid);
 8   ALTER TABLE ONLY public.login DROP CONSTRAINT useridpk;
       public            postgres    false    201            �   '   x�3��)ͬ�442615�2�,H,)�L�L����qqq ���     