PGDMP     -            
        y            postgres    13.2    13.2     ?           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ?           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ?           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            ?           1262    13442    postgres    DATABASE     h   CREATE DATABASE postgres WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Portuguese_Brazil.1252';
    DROP DATABASE postgres;
                postgres    false            ?           0    0    DATABASE postgres    COMMENT     N   COMMENT ON DATABASE postgres IS 'default administrative connection database';
                   postgres    false    2988            ?            1259    16402    login    TABLE     ?   CREATE TABLE public.login (
    userid integer NOT NULL,
    username character varying,
    userpassword character varying,
    ativo integer DEFAULT 0
);
    DROP TABLE public.login;
       public         heap    postgres    false            ?          0    16402    login 
   TABLE DATA           F   COPY public.login (userid, username, userpassword, ativo) FROM stdin;
    public          postgres    false    201   '       #           2606    16409    login useridpk 
   CONSTRAINT     P   ALTER TABLE ONLY public.login
    ADD CONSTRAINT useridpk PRIMARY KEY (userid);
 8   ALTER TABLE ONLY public.login DROP CONSTRAINT useridpk;
       public            postgres    false    201            ?   (   x?3?,H,)?L?L?442615?4?2??)ͬB?c???? ??	3     