log4net.PushoverAppender
========================

Pushover appender to log4net

Appender configuration: 

    <appender name="PushoverAppender" type="log4net.Appender.PushoverAppender">
      <applicationName value="PushoverTestMvc" />
      <applicationKey value="Your-application-key" />
      <userKey value="Your-user-key" />
      <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="%date [%thread] %-5level %logger [%property{NDC}] - %message%newline" />
      </layout>
    </appender>

Install via nuget

    Install-Package log4net.Appender.PushoverAppender
