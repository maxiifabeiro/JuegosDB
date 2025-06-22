CREATE FUNCTION FN_ClasificacionEdadTexto (
    @IDClasificacionEdad INT
)
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @Resultado VARCHAR(50);

    SET @Resultado =
        CASE @IDClasificacionEdad
            WHEN 1 THEN 'ATP - Todo p�blico'
            WHEN 2 THEN '+7 a�os'
            WHEN 3 THEN '+13 a�os'
            WHEN 4 THEN '+16 a�os'
            WHEN 5 THEN '+18 a�os'
            ELSE 'Desconocida'
        END;

    RETURN @Resultado;
END;
